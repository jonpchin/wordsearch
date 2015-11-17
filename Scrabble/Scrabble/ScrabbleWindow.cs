using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrabble
{
    public partial class MainWindow : Form
    {
        /*
        This class holds UI information and captures events
        and interacts with the Game class
        */
        Game game;
        //global variable for 2D array of labels for front end
        public static Button[,] FrontEndBoard = new Button[15, 15];
        //list of seven Buttons representing players hand
        public static Button[] PlayerHandButtons = new Button[7];
        //this is the tile the player selects from his hand
        public static string SelectedTile = " ";
        //List of tiles that are placed on the board
        public static List<string> PlacedTiles = new List<string>();
        //x and y coordinates of all the placed tiles. used to pass into checkWord function
        public static List<KeyValuePair<int, int>> CoordinatePairs = new List<KeyValuePair<int, int>>();

        public MainWindow()
        {
            InitializeComponent();
            game = new Game();

            //setups output textbox
            RichTextBox OutPutTextBox = new RichTextBox();
            OutPutTextBox.Name = "Scrabble Console";
            //sets the location of output textbox
            OutPutTextBox.Left = 550;
            OutPutTextBox.Top = 40;
            //sets size of output textbox
            OutPutTextBox.AutoSize = false;
            OutPutTextBox.Size = new System.Drawing.Size(300, 450);

            int i;
            int j;
            //skips players turn
            Button Pass = new Button();
            Pass.Text = "Pass";
            Pass.Size = new Size(100, 40);
            Pass.Location = new Point(550, 500);

            Pass.Click += delegate (System.Object o, System.EventArgs e)
            {
                OutPutTextBox.Text += "You pass.\n";
               
            };
            this.Controls.Add(Pass);

            //remove all selected tiles to get new tiles
            Button Discard = new Button();
            Discard.Text = "Discard";
            Discard.Size = new Size(100, 40);
            Discard.Location = new Point(650, 500);
            
            Discard.Click += delegate (System.Object o, System.EventArgs e)
            {
                OutPutTextBox.Text += "You remove your tiles and get new ones.\n";
                      
            };
            this.Controls.Add(Discard);

            //check if all tiles placed on the board are valid words
            Button Submit = new Button();
            Submit.Text = "Submit";
            Submit.Size = new Size(100, 40);
            Submit.Location = new Point(750, 500);

            Submit.Click += delegate (System.Object o, System.EventArgs e)
            {
                //call checkWords function

            };

            this.Controls.Add(Submit);

            for (i = 0; i < 15; i++)
            {
                for (j = 0; j < 15; j++)
                {
                    FrontEndBoard[i, j] = new Button();
                    FrontEndBoard[i, j].Text = " ";
                    FrontEndBoard[i, j].Size = new Size(40, 40);
                    FrontEndBoard[i, j].Location = new Point(j * 30+40, i * 30+40);

                    int TempI = i;
                    int TempJ = j;

                    //this event happens when one of the buttons on the front board is clicked
                    FrontEndBoard[i, j].Click += delegate (System.Object o, System.EventArgs e)
                    {
                        
                        string BoardLetter = " ";
                  
                        int IndexValue = 0;

                        //if there is already a letter on the frontBoard then its removed
                        //placed back into the players hand
                        if (FrontEndBoard[TempI,TempJ].Text == " ")
                        {
                            //updating backend Board by placing string
                            Game.ScrabbleBoard[TempI, TempJ] = BoardLetter;
                            //updating frontBoard
                            FrontEndBoard[TempI, TempJ].Text = SelectedTile;
                            PlacedTiles.Add(SelectedTile);
                            //storing x and y coordinates to be called when checking for valid words
                            CoordinatePairs.Add(new KeyValuePair<int, int>(TempI, TempJ));
                            SelectedTile = " ";
                            
                        }
                        else
                        {
                            //look through all placed Tiles and then put it back in the hand
                            foreach (string item in PlacedTiles)
                            {
                                
                                if (FrontEndBoard[TempI, TempJ].Text == item)
                                {   
                                    //searchs for empty tile in players hand
                                    for(int k=0; k<7; k++)
                                    {
                                        if (PlayerHandButtons[k].Text == " ")
                                        {
                                            IndexValue = k;
                                            break;
                                        }
                                    }
                                    BoardLetter = item;
                                    
                                    PlacedTiles.Remove(item);
                                    break;
                                }
                                IndexValue++;
                            }
                            //updating backend Board by removing string
                            Game.ScrabbleBoard[TempI, TempJ] = " ";
                            //updating frontend Board
                            FrontEndBoard[TempI, TempJ].Text = " ";
                            PlayerHandButtons[IndexValue].Text = BoardLetter;
                            
                            //removes x and y coordinates from CoordinatePairs
                            CoordinatePairs.Remove(new KeyValuePair<int, int>(TempI, TempJ));
                            
                        }
                        
                    };
                    this.Controls.Add(FrontEndBoard[i, j]);
                    this.Controls.Add(OutPutTextBox);
                }
            }

            //sets up the first seven tiles for the players hand
            for (i = 0; i < 7; i++)
            {
                Game.PlayerHand.Add(Game.DrawTile());
                PlayerHandButtons[i] = new Button();
                PlayerHandButtons[i].Text = Game.PlayerHand[i].GetLetter();
                PlayerHandButtons[i].Size = new Size(40, 40);
                PlayerHandButtons[i].Location = new Point(i * 50 + 90, 510);
                int Temp = i;
                //this event happens when a player clicks on one his seven tiles in his hand
                PlayerHandButtons[i].Click += delegate (System.Object o, System.EventArgs e)
                {
                    //if a blank tile is selected then place place the tile back into the hand
                    if(PlayerHandButtons[Temp].Text == " ")
                    {
                        PlayerHandButtons[Temp].Text = SelectedTile;
                        SelectedTile = " ";
                    }
                    //prevents players from removing multiple tiles from hand without placing on board
                    else if (SelectedTile != " ")
                    {

                    }
                    
                    else
                    {
                        //tile will get ready before being placed on the board
                        SelectedTile = PlayerHandButtons[Temp].Text;
                        PlayerHandButtons[Temp].Text = " ";
                    }
                    
                };
                this.Controls.Add(PlayerHandButtons[i]);
            }


        }
        
        

        
       

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.NewGame(); //Calls new game method from game class
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Exits program
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        

        
        


    }
}
