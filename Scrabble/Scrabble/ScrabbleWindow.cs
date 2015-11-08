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
