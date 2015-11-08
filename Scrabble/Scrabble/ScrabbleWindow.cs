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
        public MainWindow()
        {
            InitializeComponent();
            game = new Game();

            string yourLetter, theirLetter;

            do //Do while loop prevents letters from being the same for first draw
            {
                yourLetter = game.DrawLetter();
                theirLetter = game.DrawLetter();
            } while (yourLetter.Equals(theirLetter));
            yourFirstDraw.Text = yourLetter; //Display letters and whose turn in labels and buttons
            theirFirstDraw.Text = theirLetter;
            firstTurnLabel.Text = game.WhoseTurn(yourLetter, theirLetter);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.NewGame(); //Calls new game method from game class
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Exits program
        }
    }
}
