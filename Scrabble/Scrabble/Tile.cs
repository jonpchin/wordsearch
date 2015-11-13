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
        String letter;
        int score;

        public Tile(String thisLetter, int thisScore)
        {
            letter = thisLetter;
            score = thisScore;
        }
        
        public String getLetter()
        {
            return letter;
        }
        public int getScore()
        {
            return score;
        }


    }
}
