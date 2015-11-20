using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrabble
{
    /*
    This class will perform the game logic in the backend
    */

    class Game
    {
        
        //board is 15x15
        private const int ROWS = 15;
        private const int COLS = 15;

        //global static board array, yes its bad practice but its convienent 
        public static string[,] ScrabbleBoard = new String[ROWS, COLS];
        //dynamic array of chars for deck of Tiles
        public static List<Tile> DeckOfTiles = new List<Tile>();

        //players hand of seven tiles
        public static List<Tile> PlayerHand = new List<Tile>();
        //computers hand of seven tiles
        public static List<Tile> ComputerHand = new List<Tile>();
        //list of tiles that are selected
        public static List<Tile> SelectedHand = new List<Tile>();

        

        public Game()
        {
            //at the start of the application read in all the words into dictionary
            SearchWord.MakeDictionary();
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
                    ScrabbleBoard[i,j] = " ";
                }
            }
            //adding letter frequency into deck of Tiles. Total is 100 tiles.
            DeckOfTiles.Add(new Tile("K", 5));
            DeckOfTiles.Add(new Tile("J", 8));
            DeckOfTiles.Add(new Tile("X", 10));
            DeckOfTiles.Add(new Tile("Q", 10));
            DeckOfTiles.Add(new Tile("Z", 10));
            
            for (int i=0; i < 2; i++)
            {
                //two blank(wild) tiles are added which are worth zero points
                DeckOfTiles.Add(new Tile(" ", 0));
                DeckOfTiles.Add(new Tile("B", 3));
                DeckOfTiles.Add(new Tile("C", 3));
                DeckOfTiles.Add(new Tile("M", 3));
                DeckOfTiles.Add(new Tile("P", 3));

                DeckOfTiles.Add(new Tile("F", 4));
                DeckOfTiles.Add(new Tile("H", 4));
                DeckOfTiles.Add(new Tile("V", 4));
                DeckOfTiles.Add(new Tile("W", 4));
                DeckOfTiles.Add(new Tile("Y", 4));
            }
            for (int i = 0; i < 3; i++)
            {

                DeckOfTiles.Add(new Tile("G", 2));
              
            }
            for (int i = 0; i < 4; i++)
            {

                DeckOfTiles.Add(new Tile("L", 1));
                DeckOfTiles.Add(new Tile("S", 1));
                DeckOfTiles.Add(new Tile("U", 1));
                DeckOfTiles.Add(new Tile("D", 2));

            }

            for (int i = 0; i < 6; i++)
            {

                DeckOfTiles.Add(new Tile("N", 1));
                DeckOfTiles.Add(new Tile("R", 1));
                DeckOfTiles.Add(new Tile("T", 1));

            }
            for (int i = 0; i < 8; i++)
            {
                DeckOfTiles.Add(new Tile("O", 1));
            }
            for (int i = 0; i < 9; i++)
            {
                DeckOfTiles.Add(new Tile("A", 1));
                DeckOfTiles.Add(new Tile("I", 1));
            }

            for (int i = 0; i < 12; i++)
            {
                DeckOfTiles.Add(new Tile("E", 1));
                
            }
           
            //shuffles deck
            ShuffleTiles();
            //used for testing purpose only
            PrintDeck();
            //loads seven tiles of computer

            SetupComputerHand();


        }
        //function used to randomly select a player
        public string DrawLetter()
        {
            Random rand = new Random();
            return ((char)('A' + rand.Next(0, 26))).ToString(); //Returns random letter A-Z
        }
        
       

        public string WhoseTurn(string yourLetter, string theirLetter)
        {
            if (String.Compare(yourLetter, theirLetter) == -1) //Compares the first two drawn letters to see who goes first
                return "Your Turn";

            return "Their Turn";            
        }

        //will randomize the deck of Tiles
        public void ShuffleTiles()
        {
            Random rand = new Random();
            //generates a random number in between 0 and 99 
            
            Tile temp;

            //randomly pick two values and make 200 swaps to simulate shuffling
            for(int i=0; i<200; i++)
            {
                int value1 = rand.Next(100);
                int value2 = rand.Next(100);

                temp = DeckOfTiles[value1];
                DeckOfTiles[value1] = DeckOfTiles[value2];
                DeckOfTiles[value2] = temp; 
            }
        }
        //used to draw a random tile from the Tile deck
        public static Tile DrawTile()
        {
            Tile temp = DeckOfTiles[DeckOfTiles.Count - 1];
            //deletes the last tile in the deck
            DeckOfTiles.RemoveAt(DeckOfTiles.Count - 1);
            return temp;
        }

        //prints the deck of tiles onto console, used only for testing purposes
        //to see if deck is shuffled and working properly
        public void PrintDeck()
        {
            for(int i=0; i<100; i++)
            {
                Debug.WriteLine("Tile Letter : " + DeckOfTiles[i].GetLetter() + " Points " + DeckOfTiles[i].GetScore());
            }
        }
        //sets up the first seven tiles for the computers hand
        public void SetupComputerHand()
        {
            for(int i=0; i<7; i++)
            {
                ComputerHand.Add(DrawTile());
            }
        }
        

        //Function takes two one list of Pairs.
        //Searches left and up for all buildable words from each added tile
        //Then checks each built word to see if it is valid
        // .Value is y coordinate .Key is x coordinate
        public static void CheckWords(List<KeyValuePair<int, int>> CoordinatePairs)
        {
            //these are two of the strings returned at the end of the function
            string VerticalWord = "";
            string HorizontalWord = "";
            

            for (int i = 0; i < CoordinatePairs.Count; i++) //Checks each column for full word
            {

                string word = "";
                string tile = ScrabbleBoard[CoordinatePairs[i].Key, CoordinatePairs[i].Value];
                int j = CoordinatePairs[i].Key; //Move up a row

                if (j == 0) //Prevent Out of bounds error in scrabble board array
                    break;
                
                while (j >= 0 && tile != " ")
                {
                    tile = ScrabbleBoard[j--, CoordinatePairs[i].Value]; //Get char at tile position, moving up until empty tile found
                    word = tile + word;                                   //append each tile char to string
                }
                word = word.Trim();
  
               
               
                //Chars were added in reverse order. Reverse back to normal order 
                //checks if valid word and returns true or false
                if (SearchWord.ValidWord(word))
                {
                    VerticalWord = word;
                    int points = CalculateScore(VerticalWord);
                    MainWindow.OutPutTextBox.Text += ("The word " + VerticalWord + " scored you " + points + "\n");
                }

                //need to add function to get point values and add them here
            }
           

            for (int i = 0; i < CoordinatePairs.Count; i++) //identical to above loop, but instead checks words to the LEFT
            {
                string word = "";
                string tile = ScrabbleBoard[CoordinatePairs[i].Key, CoordinatePairs[i].Value];
                int j = CoordinatePairs[i].Value;

                if (j == 0)
                    break;

                while (j >= 0 && tile != " ")
                {
                    tile = ScrabbleBoard[CoordinatePairs[i].Key, j--]; //adds tiles to the LEFT of the played tile
                    word = tile + word;
                }
                word = word.Trim();

                
                //check if valid word and return true or false
                if (SearchWord.ValidWord(word))
                {
                    HorizontalWord = word;
                    int points = CalculateScore(HorizontalWord);
                    MainWindow.OutPutTextBox.Text += ("The word " + HorizontalWord + " scored you " + points + "\n");
                }

            }
           
        }
        //calculates the points for each word scored and returns the score
        public static int CalculateScore(string word)
        {
            return 0;
        }

        //switchtes to the computers turn
        public static void SwitchTurns()
        {

        }
        
    }
}
