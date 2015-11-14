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

        public MainWindow()
        {
            InitializeComponent();
            game = new Game();

            //setups output textbox
            TextBox OutPutTextBox = new TextBox();
            OutPutTextBox.Name = "Scrabble Console";
            //sets the location of output textbox
            OutPutTextBox.Left = 550;
            OutPutTextBox.Top = 40;
            //sets size of output textbox
            OutPutTextBox.AutoSize = false;
            OutPutTextBox.Size = new System.Drawing.Size(300, 450);

            int i;
            int j;
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
                            FrontEndBoard[TempI, TempJ].Text = SelectedTile;
                            PlacedTiles.Add(SelectedTile);
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
                            PlayerHandButtons[IndexValue].Text = BoardLetter;
                            FrontEndBoard[TempI, TempJ].Text = " ";
                            
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
                PlayerHandButtons[i].Location = new Point(i * 50 + 20, 510);
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
