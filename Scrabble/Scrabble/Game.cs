using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble
{
    /*
    This class will perform the game logic in the backend
    */

    class Game
    {
        Random rand;

        public Game()
        {
            SearchWord search = new SearchWord();
            rand = new Random();
        }

        public void NewGame()
        {

        }

        public string DrawLetter()
        {
            return ((char)('A' + rand.Next(0, 26))).ToString(); //Returns random letter A-Z
        }

        public string WhoseTurn(string yourLetter, string theirLetter)
        {
            if (String.Compare(yourLetter, theirLetter) == -1) //Compares the first two drawn letters to see who goes first
                return "Your Turn";

            return "Their Turn";            
        }
    }
}
