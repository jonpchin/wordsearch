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
        public static String SelectedTile;
        //keeps track of which index the Tile that was selected
        public static int SelectedIndex;

        public MainWindow()
        {
            InitializeComponent();
            game = new Game();


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
                        //if there is already a letter on the frontBoard then its removed
                        //placed back into the players hand
                        if(FrontEndBoard[TempI,TempJ].Text == " ")
                        {
                            FrontEndBoard[TempI, TempJ].Text = SelectedTile;
                            SelectedTile = " ";
                            
                        }
                        else
                        {
                            PlayerHandButtons[SelectedIndex].Text = Game.PlayerHand[SelectedIndex].GetLetter();
                            FrontEndBoard[TempI, TempJ].Text = " ";
                        }
                        
                    };
                    this.Controls.Add(FrontEndBoard[i, j]);
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
                    SelectedTile = PlayerHandButtons[Temp].Text;
                    SelectedIndex = Temp;
                    PlayerHandButtons[Temp].Text = " ";
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
