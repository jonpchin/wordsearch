using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

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
        //list of tiles a player selects from his hand
        public static List<string> SelectedTiles = new List<string>();
        //List of tiles that are placed on the board
        public static List<string> PlacedTiles = new List<string>();
        //x and y coordinates of all the placed tiles. used to pass into checkWord function
        public static List<KeyValuePair<int, int>> CoordinatePairs = new List<KeyValuePair<int, int>>();
        //display output box to log game events
        public static RichTextBox OutPutTextBox = new RichTextBox();
        //list of x and y coordinates of all validated disabled tiles on the board. Used to check adjacency
        public static List<KeyValuePair<int, int>> ValidPairs = new List<KeyValuePair<int, int>>();

        public MainWindow()
        {
            InitializeComponent();
            game = new Game();

            //setups output textbox
           
            OutPutTextBox.Name = "Scrabble Console";
            //sets the location of output textbox
            OutPutTextBox.Left = 550;
            OutPutTextBox.Top = 40;
            //sets size of output textbox
            OutPutTextBox.AutoSize = false;
            OutPutTextBox.Size = new System.Drawing.Size(300, 450);

            //setups the labels for the points for player and computer
            Label PlayerLabel = new Label();
            PlayerLabel.Text = "Player Score";
            PlayerLabel.Location = new Point(870, 460);
            Label PlayerScore = new Label();
            PlayerScore.Text = "0";
            PlayerScore.Location = new Point(895, 485);

            Label ComputerLabel = new Label();
            ComputerLabel.Text = "Computer Score";
            ComputerLabel.Location = new Point(870, 50);

            Label ComputerScore = new Label();
            ComputerScore.Text = "0";
            ComputerScore.Location = new Point(900, 75);

            this.Controls.Add(PlayerLabel);
            this.Controls.Add(PlayerScore);
            this.Controls.Add(ComputerLabel);
            this.Controls.Add(ComputerScore);

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
                //if player has not placed any tiles on the board
                if(PlacedTiles.Count == 0)
                {
                    
                    foreach(Button PlayerTile in PlayerHandButtons)
                    {
                        if (PlayerTile.BackColor == Color.Green)
                        {
                               
                            PlayerTile.Text = Game.DrawTile();
                            PlayerTile.BackColor = SystemColors.ButtonFace;
                            PlayerTile.UseVisualStyleBackColor = true;
                                
                        }
                            
                    }         
                    //emptys the list
                    SelectedTiles.Clear();
                    OutPutTextBox.Text += "You remove your tiles and get new ones.\n";
                }
                else
                {
                    OutPutTextBox.Text += "You need to remove the tiles from the board first.\n";
                }
               
            };
            this.Controls.Add(Discard);

            //check if all tiles placed on the board are valid words
            Button Submit = new Button();
            Submit.Text = "Submit";
            Submit.Size = new Size(100, 40);
            Submit.Location = new Point(750, 500);

            Submit.Click += delegate (System.Object o, System.EventArgs e)
            {
                int Total;
                if ((Total = Game.CheckWords(CoordinatePairs)) > 0 )
                {
                    //then all the coordinates are valid and should be saved for future adjacency checks
                    foreach(KeyValuePair<int, int> item in CoordinatePairs)
                    {
                        ValidPairs.Add(new KeyValuePair<int, int>(item.Key, item.Value));
                    } 
                    OutPutTextBox.Text += "You scored a total of " + Total + " points.\n";
                    //updating the score for the players front end
                    PlayerScore.Text = (Convert.ToInt32(PlayerScore.Text) + Convert.ToInt32(Total)).ToString();
                    //replaces the tiles that are disabled in the players hand
                    foreach (Button item in PlayerHandButtons)
                    {
                        if (item.Enabled == false)
                        {
                            item.Enabled = true;
                            item.Text = Game.DrawTile();
                        }
                    }
                    //removes the list of placed tiles
                    PlacedTiles.Clear();
                    //disables tiles so player can't remove them
                    foreach (KeyValuePair<int, int> item in CoordinatePairs)
                    {
                        FrontEndBoard[item.Key, item.Value].Enabled = false;
                    }
                    //removes all coordinates from list
                    CoordinatePairs.Clear();
                    //now its the computers turn
                    Game.SwitchTurns();
                }
                else if (Total == -1)
                {
                    OutPutTextBox.Text += "You are not allowed to form islands.\n";
                }
                else
                {
                    OutPutTextBox.Text += "That word is not valid.\n";
                }
                

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
                        
                        int IndexValue = 0;

                        //if there is already a letter on the frontBoard then its removed
                        //placed back into the players hand
                        if (FrontEndBoard[TempI,TempJ].Text == " ")
                        {
                            
                            //updating frontBoard, checking to make sure list is not empty
                            if(SelectedTiles.Count != 0)
                            {
                                //updating backend Board by placing string
                                Game.ScrabbleBoard[TempI, TempJ] = SelectedTiles[0];
                                FrontEndBoard[TempI, TempJ].Text = SelectedTiles[0];
                                int counter = 0;
                                int index = 1;
                                //searches for letter in the SelectedTiles list to be disabled
                                foreach (Button item in PlayerHandButtons)
                                {
                                    if (SelectedTiles[0] == item.Text && item.Enabled==true)
                                    {
                                        index = counter;
                                        break;
                                    }
                                    counter++;
                                }
                                //disables the tile in the hand that was placed on the board
                                PlayerHandButtons[index].BackColor = SystemColors.ButtonFace;
                                PlayerHandButtons[index].UseVisualStyleBackColor = true;
                                PlayerHandButtons[index].Enabled = false;

                                PlacedTiles.Add(SelectedTiles[0]);
                                SelectedTiles.RemoveAt(0);

                                //storing x and y coordinates to be called when checking for valid words
                                CoordinatePairs.Add(new KeyValuePair<int, int>(TempI, TempJ));
                                
                            }            
                            
                        }
                        else
                        {

                            //searchs for disabled tile in players hand
                            for(int k=0; k<7; k++)
                            {
                                if (PlayerHandButtons[k].Text == FrontEndBoard[TempI, TempJ].Text && PlayerHandButtons[k].Enabled == false)
                                {
                                    IndexValue = k;
                                    break;
                                }
                                IndexValue++;
                            }
                                               
                            PlacedTiles.Remove(FrontEndBoard[TempI, TempJ].Text);

                            //updating backend Board by removing string
                            Game.ScrabbleBoard[TempI, TempJ] = " ";
                            //updating frontend Board
                            FrontEndBoard[TempI, TempJ].Text = " ";
                            PlayerHandButtons[IndexValue].Enabled = true;
                            
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

                PlayerHandButtons[i] = new Button();
                PlayerHandButtons[i].Text = Game.DrawTile();
                PlayerHandButtons[i].Size = new Size(40, 40);
                PlayerHandButtons[i].Location = new Point(i * 50 + 90, 510);
                int Temp = i;
                //this event happens when a player clicks on one his seven tiles in his hand
                PlayerHandButtons[i].Click += delegate (System.Object o, System.EventArgs e)
                {
                    //if a blank tile is selected then allow player to enter the desired letter
                    if(PlayerHandButtons[Temp].Text == " ")
                    {
                        //make sure to add check to ensure only one letter is entered and not digits or strings
                        string ReturnedLetter = Microsoft.VisualBasic.Interaction.InputBox("Enter a Letter", "Enter Letter", "Enter a letter please", 200, 200);
                        //checks if the string is only 1 uppercase letter
                        if (Regex.IsMatch(ReturnedLetter, @"^[A-Z]+$") && ReturnedLetter.Length == 1)
                        {
                            PlayerHandButtons[Temp].Text = ReturnedLetter;
                        }
                        
                     }
                    //if button is already selected then deselect it
                    else if (PlayerHandButtons[Temp].BackColor == Color.Green)
                    {
                        PlayerHandButtons[Temp].BackColor = SystemColors.ButtonFace;
                        PlayerHandButtons[Temp].UseVisualStyleBackColor = true;
                   
                        //searches for letter in the SelectedTiles list to be removed
                        SelectedTiles.Remove(PlayerHandButtons[Temp].Text);
                    }
                    
                    else
                    {
                        //tile will get ready before being placed on the board
                        SelectedTiles.Add(PlayerHandButtons[Temp].Text);
                        //background color of button will change to show it is selected
                        PlayerHandButtons[Temp].BackColor = Color.Green;
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
