using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        SearchWord search; //Holds dictionary of words and word check functions
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
        //list of tiles that are selected
        public static List<Tile> selectedHand = new List<Tile>();
 
        public Game()
        {
            
            search = new SearchWord();
            rand = new Random();
            //starts a new game
            NewGame();
        }

        //intitalizes backend board to blanks and setups the 100 tiles
        //sets up player hand and computers hand
        public void NewGame()
        {
            
            for (int i=0; i<ROWS; i++)
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
            //loads seven tiles into starting hand of player and computer
            setupPlayerHand();
            setupComputerHand();


        }
        //function used to randomly select a player
        public string DrawLetter()
        {
            return ((char)('A' + rand.Next(0, 26))).ToString(); //Returns random letter A-Z
        }
        
        //used to draw a random tile from the Tile deck
        public Tile drawTile()
        {
            Tile temp = deckOfTiles[deckOfTiles.Count - 1];
            //deletes the last tile in the deck
            deckOfTiles.RemoveAt(deckOfTiles.Count - 1);
            return temp;
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
            
            Tile temp;

            //randomly pick two values and make 200 swaps to simulate shuffling
            for(int i=0; i<200; i++)
            {
                int value1 = rand.Next(100);
                int value2 = rand.Next(100);

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
                Debug.WriteLine("Tile Letter : " + deckOfTiles[i].getLetter() + " Points " + deckOfTiles[i].getScore());
            }
        }
        //sets up the first seven tiles for the computers hand
        public void setupComputerHand()
        {
            for(int i=0; i<7; i++)
            {
                computerHand.Add(drawTile());
            }
        }
        //sets up the first seven tiles for the players hand
        public void setupPlayerHand()
        {
            for (int i = 0; i < 7; i++)
            {
                playerHand.Add(drawTile());
            }
        }
        
        //Function takes two lists. One for x coordinates of added tiles, one more y coordinates
        //Searches left and up for all buildable words from each added tile
        //Then checks each built word to see if it is valid
        public void CheckWords(List<int> playedX, List<int> playedY)
        {
            for (int i = 0; i < playedX.Count; i++) //Checks each column for full word
            {
                string word = "";
                char tile = scrabbleBoard[playedY[i], playedX[i]];
                int j = playedY[i] - 1; //Move up a row

                if (j == 0) //Prevent Out of bounds error in scrabble board array
                    break;
                
                while (tile != ' ')
                {
                    tile = scrabbleBoard[playedY[j--], playedX[i]]; //Get char at tile position, moving up until empty tile found
                    word += tile;                                   //append each tile char to string
                }
                
                word = word.Reverse().ToString(); //Chars were added in reverse order. Reverse back to normal order 
                search.ValidWord(word); //checks if valid word and returns true or false

                //need to add function to get point values and add them here
            }

            for (int i = 0; i < playedY.Count; i++) //identical to above loop, but instead checks words to the LEFT
            {
                string word = "";
                char tile = scrabbleBoard[playedY[i], playedX[i]];
                int j = playedX[i] - 1;

                if (j == 0)
                    break;

                while (tile != ' ')
                {
                    tile = scrabbleBoard[playedY[i], playedX[j--]]; //adds tiles to the LEFT of the played tile
                    word += tile;
                }

                word = word.Reverse().ToString(); 
                search.ValidWord(word); //check if valid word and return true or false

                //need to add function to get point values and add them here
            }
        }
        
    }
}
