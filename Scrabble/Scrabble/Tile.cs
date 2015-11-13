using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble
{
    //represents a tile with a letter that a player can place on the board

    public class Tile
    {
        String letter;
        int score;
    

        public Tile(String thisLetter, int thisScore)
        {
            letter = thisLetter;
            score = thisScore;
        }
        public Tile(String thisLetter)
        {
            letter = thisLetter;
           
        }

        public Tile()
        {
        }

        public String GetLetter()
        {
            return letter;
        }
        public int GetScore()
        {
            return score;
        }
        public void SetLetter(String thisLetter)
        {
            letter = thisLetter;
        }
      


    }
}
