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
        //board is 15x15
        private const int ROWS = 15;
        private const int COLS = 15;

        //global static board array, yes its bad practice but its convienent 
        public static char[,] scrabbleBoard = new char[ROWS, COLS];
        //dynamic array of chars for deck of Tiles
        public static List<Tile> deckOfTiles = new List<Tile>();

        //players hand of seven tiles
        public static List<Tile> playerHand = new List<Tile>();
        //computers hand of seven tiles
        public static List<Tile> computerHand = new List<Tile>();

        public Game()
        {
            SearchWord search = new SearchWord();
            rand = new Random();
        }

        //intitalizes backend board to blanks and setups the 100 tiles
        //sets up player hand and computers hand
        public void NewGame()
        {
            
            for(int i=0; i<ROWS; i++)
            {
                for(int j=0; j<COLS; j++)
                {
                    //intitalizing board to default blank chars
                    scrabbleBoard[i,j] = ' ';
                }
            }
            //adding letter frequency into deck of Tiles. Total is 100 tiles.
            deckOfTiles.Add(new Tile('K', 5));
            deckOfTiles.Add(new Tile('J', 8));
            deckOfTiles.Add(new Tile('X', 10));
            deckOfTiles.Add(new Tile('Q', 10));
            deckOfTiles.Add(new Tile('Z', 10));
            
            for (int i=0; i < 2; i++)
            {
                //two blank(wild) tiles are added which are worth zero points
                deckOfTiles.Add(new Tile(' ', 0));
                deckOfTiles.Add(new Tile('B', 3));
                deckOfTiles.Add(new Tile('C', 3));
                deckOfTiles.Add(new Tile('M', 3));
                deckOfTiles.Add(new Tile('P', 3));

                deckOfTiles.Add(new Tile('F', 4));
                deckOfTiles.Add(new Tile('H', 4));
                deckOfTiles.Add(new Tile('V', 4));
                deckOfTiles.Add(new Tile('W', 4));
                deckOfTiles.Add(new Tile('Y', 4));
            }
            for (int i = 0; i < 3; i++)
            {

                deckOfTiles.Add(new Tile('G', 2));
              
            }
            for (int i = 0; i < 4; i++)
            {

                deckOfTiles.Add(new Tile('L', 1));
                deckOfTiles.Add(new Tile('S', 1));
                deckOfTiles.Add(new Tile('U', 1));
                deckOfTiles.Add(new Tile('D', 2));

            }

            for (int i = 0; i < 6; i++)
            {

                deckOfTiles.Add(new Tile('N', 1));
                deckOfTiles.Add(new Tile('R', 1));
                deckOfTiles.Add(new Tile('T', 1));

            }
            for (int i = 0; i < 8; i++)
            {
                deckOfTiles.Add(new Tile('O', 1));
            }
            for (int i = 0; i < 9; i++)
            {
                deckOfTiles.Add(new Tile('A', 1));
                deckOfTiles.Add(new Tile('I', 1));
            }

            for (int i = 0; i < 12; i++)
            {
                deckOfTiles.Add(new Tile('E', 1));
                
            }
            //shuffles deck
            shuffleTiles();
            //used for testing purpose only
            printDeck();


        }
        //we may not need this function, the tile frequency I used above is what is 
        //actually used in the game, we will just shuffle the deck of Tiles to randomize it
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

        //will randomize the deck of Tiles
        public void shuffleTiles()
        {
            Random rand = new Random();
            //generates a random number in between 0 and 99 
            int value1 = rand.Next(100);
            int value2 = rand.Next(100);
            Tile temp;

            //randomly pick two values and make 200 swaps to simulate shuffling
            for(int i=0; i<200; i++)
            {
                temp = deckOfTiles[value1];
                deckOfTiles[value1] = deckOfTiles[value2];
                deckOfTiles[value2] = temp; 
            }
        }

        //prints the deck of tiles onto console, used only for testing purposes
        //to see if deck is shuffled and working properly
        public void printDeck()
        {
            for(int i=0; i<100; i++)
            {
                Console.WriteLine("Tile Letter : " + deckOfTiles[i].getLetter() + " Points " + deckOfTiles[i].getScore());
            }
        }
        

        
    }
}
