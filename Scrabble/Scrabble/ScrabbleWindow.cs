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
        public static Button[,] frontEndBoard = new Button[15, 15];
      
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
                    frontEndBoard[i, j] = new Button();
                    frontEndBoard[i, j].Text = "" + i*j;
                    frontEndBoard[i, j].Size = new Size(40, 40);
                    frontEndBoard[i, j].Location = new Point(j * 30+40, i * 30+40);
                    this.Controls.Add(frontEndBoard[i, j]);
                }
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
