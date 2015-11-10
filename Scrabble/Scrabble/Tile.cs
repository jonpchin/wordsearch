using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble
{
    //represents a tile with a letter that a player can place on the board

    class Tile
    {
        char letter;
        int score;

        public Tile(char thisLetter, int thisScore)
        {
            letter = thisLetter;
            score = thisScore;
        }
        
        public char getLetter()
        {
            return letter;
        }
        public int getScore()
        {
            return score;
        }


    }
}
