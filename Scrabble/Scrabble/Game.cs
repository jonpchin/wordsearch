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
        public static List<string> DeckOfTiles = new List<string>();
        //computers hand of seven tiles
        public static List<string> ComputerHand = new List<string>();
        //sets up a Dictionary for score lookups
        public static Dictionary<string, int> ScoreTable = new Dictionary<string, int>();

        //Holds words defined in text file
        public static Dictionary<string, int> wordList; 

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
            ScoreTable[" "] = 0;
            ScoreTable["A"] = 1;
            ScoreTable["B"] = 3;
            ScoreTable["C"] = 3;
            ScoreTable["D"] = 2;
            ScoreTable["E"] = 1;
            ScoreTable["F"] = 4;
            ScoreTable["G"] = 2;
            ScoreTable["H"] = 4;
            ScoreTable["I"] = 1;
            ScoreTable["J"] = 8;
            ScoreTable["K"] = 5;
            ScoreTable["L"] = 1;
            ScoreTable["M"] = 3;
            ScoreTable["N"] = 1;
            ScoreTable["O"] = 1;
            ScoreTable["P"] = 3;
            ScoreTable["Q"] = 10;
            ScoreTable["R"] = 1;
            ScoreTable["S"] = 1;
            ScoreTable["T"] = 1;
            ScoreTable["U"] = 1;
            ScoreTable["V"] = 4;
            ScoreTable["W"] = 4;
            ScoreTable["X"] = 8;
            ScoreTable["Y"] = 4;
            ScoreTable["Z"] = 10;

            //adding letter frequency into deck of Tiles. Total is 100 tiles.
            DeckOfTiles.Add("K");
            DeckOfTiles.Add("J");
            DeckOfTiles.Add("X");
            DeckOfTiles.Add("Q");
            DeckOfTiles.Add("Z");
            
            for (int i=0; i < 2; i++)
            {
                //two blank(wild) tiles are added which are worth zero points
                DeckOfTiles.Add(" ");
                DeckOfTiles.Add("B");
                DeckOfTiles.Add("C");
                DeckOfTiles.Add("M");
                DeckOfTiles.Add("P");

                DeckOfTiles.Add("F");
                DeckOfTiles.Add("H");
                DeckOfTiles.Add("V");
                DeckOfTiles.Add("W");
                DeckOfTiles.Add("Y");
            }
            for (int i = 0; i < 3; i++)
            {

                DeckOfTiles.Add("G");
              
            }
            for (int i = 0; i < 4; i++)
            {

                DeckOfTiles.Add("L");
                DeckOfTiles.Add("S");
                DeckOfTiles.Add("U");
                DeckOfTiles.Add("D");

            }

            for (int i = 0; i < 6; i++)
            {

                DeckOfTiles.Add("N");
                DeckOfTiles.Add("R");
                DeckOfTiles.Add("T");

            }
            for (int i = 0; i < 8; i++)
            {
                DeckOfTiles.Add("O");
            }
            for (int i = 0; i < 9; i++)
            {
                DeckOfTiles.Add("A");
                DeckOfTiles.Add("I");
            }

            for (int i = 0; i < 12; i++)
            {
                DeckOfTiles.Add("E");
                
            }
           
            //shuffles deck
            ShuffleTiles();
            //used for testing purpose only
            PrintDeck();
            //loads seven tiles of computer, playe hand will only be stored on front end
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
            
            string temp;

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
        public static string DrawTile()
        {
            if(DeckOfTiles.Count == 0)
            {
                //deckOfTiles is empty so game will end with this function call
                GameOver();
                //blank junk tile is returned
                return " ";
               
            }
            string temp = DeckOfTiles[DeckOfTiles.Count - 1];
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
                Debug.WriteLine("Tile Letter : " + DeckOfTiles[i]);
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
        //returns total points scored by all the letters otherwise it returns 0 which means not all letters were used
        public static int CheckWords(List<KeyValuePair<int, int>> CoordinatePairs)
        {
            //these are two of the strings returned at the end of the function
            string VerticalWord = "";
            string HorizontalWord = "";

            //this is the total score of all valid words returned at the end
            int TotalScore = 0;
            //stores all used words to prevent duplicate words
            List<string> DuplicateWords = new List<string>();

            //stores the X, Y coordinates of used words
            List<KeyValuePair<int, int>> FoundWords = new List<KeyValuePair<int, int>>();

            bool[,] UsedLetters = new bool[15, 15];
            for(int a=0; a<15; a++)
            {
                for(int b=0; b<15; b++)
                {
                    UsedLetters[a,b] = false;
                }
            }



            for (int i = 0; i < CoordinatePairs.Count; i++) //Checks each column for full word
            {

                //main letter that is guarnteed to be placed
                string MainLetter = ScrabbleBoard[CoordinatePairs[i].Key, CoordinatePairs[i].Value];
               
                //stores x, y coordinates of current word being built
                List<KeyValuePair<int, int>> Storage = new List<KeyValuePair<int, int>>();
                Storage.Add(new KeyValuePair<int, int>(CoordinatePairs[i].Key, CoordinatePairs[i].Value));
                

                int j = CoordinatePairs[i].Key;
                if (j < 14)
                {
                    j = CoordinatePairs[i].Key + 1; //Move up a row
                }
                
                 

                string BackWord = "";
                string tile = ScrabbleBoard[j, CoordinatePairs[i].Value];
                

                while (j <= 14 && ScrabbleBoard[j, CoordinatePairs[i].Value] != " ")
                {
                    //Get char at tile position, moving up until empty tile found
                    Storage.Add(new KeyValuePair<int, int>(j, CoordinatePairs[i].Value));
                    tile = ScrabbleBoard[j, CoordinatePairs[i].Value];
                    BackWord += tile;
                    j++;
                }
                BackWord.Trim();
                j = CoordinatePairs[i].Key;
                if (j > 0)
                {
                    j = CoordinatePairs[i].Key - 1;//move down the starting row
                }
                    
                string FrontWord = "";
                tile = ScrabbleBoard[j, CoordinatePairs[i].Value];

                while (j >= 0 && ScrabbleBoard[j, CoordinatePairs[i].Value] != " ")
                {

                    //Get char at tile position, moving up until empty tile found
                    Storage.Add(new KeyValuePair<int, int>(j, CoordinatePairs[i].Value));
                    tile = ScrabbleBoard[j, CoordinatePairs[i].Value];
                    FrontWord = tile + FrontWord;
                    j--;
            
                }
                FrontWord = FrontWord.Trim();
                int FrontLength = FrontWord.Length;
                int BackLength = BackWord.Length;
                

                for (int a=0; a<=FrontLength; a++)
                {
                    for(int b=0; b<=BackLength; b++)
                    {
                        if (SearchWord.ValidWord(FrontWord.Substring(a, FrontLength-a) + MainLetter + BackWord.Substring(0, BackLength-b)) && !DuplicateWords.Contains(FrontWord.Substring(a, FrontLength - a) + MainLetter + BackWord.Substring(0, BackLength - b)))
                        {
                            DuplicateWords.Add(FrontWord.Substring(a, FrontLength - a) + MainLetter + BackWord.Substring(0, BackLength - b));
                            //storing all x, y coordinates of valid word to be used to check if all letters used 
                            foreach (KeyValuePair<int, int> item in Storage)
                            {
                                FoundWords.Add(new KeyValuePair<int, int>(item.Key, item.Value));
                            }
                            //check to make sure board is not empty and checks if there is any islands
                            if (MainWindow.ValidPairs.Count != 0 && !IsConnect(Storage))
                            {
                                return -1;
                            }

                            
                            VerticalWord = FrontWord.Substring(a, FrontLength - a) + MainLetter + BackWord.Substring(0, BackLength - b);
                            int points = CalculateScore(VerticalWord);
                            TotalScore += points;
                            MainWindow.OutPutTextBox.AppendText("The word " + VerticalWord + " is worth " + points + "\n");
                            MainWindow.OutPutTextBox.ScrollToCaret();


                        }
                    }
                }

                


            }
            //horizontal words do not collide with vertical words for duplicates
            DuplicateWords.Clear();
            for (int i = 0; i < CoordinatePairs.Count; i++) //identical to above loop, but instead checks words to the LEFT
            {
                string MainLetter = ScrabbleBoard[CoordinatePairs[i].Key, CoordinatePairs[i].Value];
                string BackWord = "";

                List<KeyValuePair<int, int>> Storage = new List<KeyValuePair<int, int>>();
                //adding original coordinate
                Storage.Add(new KeyValuePair<int, int>(CoordinatePairs[i].Key, CoordinatePairs[i].Value));
                

                int j = CoordinatePairs[i].Value;
                if (j < 14)
                {
                    j = CoordinatePairs[i].Value + 1;
                }
                
                string tile = ScrabbleBoard[CoordinatePairs[i].Key, j];
               
                while (j <= 14 && ScrabbleBoard[CoordinatePairs[i].Key, j] != " ")
                {
                    //adds tiles to the RIGHT of the played tile
                    Storage.Add(new KeyValuePair<int, int>(CoordinatePairs[i].Key, j));   
                    tile = ScrabbleBoard[CoordinatePairs[i].Key, j];
                    BackWord += tile;
                    j++;

                }
                //removes trailing white space
                BackWord = BackWord.Trim();
                j = CoordinatePairs[i].Value;
                if (j > 0)
                {
                    j = CoordinatePairs[i].Value - 1; //move to the left one.
                }
                

                string FrontWord = "";
                tile = ScrabbleBoard[CoordinatePairs[i].Key, j];
                while (j >= 0 && ScrabbleBoard[CoordinatePairs[i].Key, j] != " ")
                {
                    //adds tiles to the LEFT of the played tile
                    Storage.Add(new KeyValuePair<int, int>(CoordinatePairs[i].Key, j));
                    tile = ScrabbleBoard[CoordinatePairs[i].Key, j];
                    FrontWord = tile + FrontWord;
                    j--;
 
                }
                FrontWord = FrontWord.Trim();
                int FrontLength = FrontWord.Length;
                int BackLength = BackWord.Length;
              
                for(int a=0; a<= FrontLength; a++)
                {
                    for(int b=0; b<= BackLength; b++)
                    {
                        if (SearchWord.ValidWord(FrontWord.Substring(a, FrontLength - a) + MainLetter + BackWord.Substring(0, BackLength - b)) && !DuplicateWords.Contains(FrontWord.Substring(a, FrontLength - a) + MainLetter + BackWord.Substring(0, BackLength - b)) )
                        {
                            DuplicateWords.Add(FrontWord.Substring(a, FrontLength - a) + MainLetter + BackWord.Substring(0, BackLength - b));
                            foreach (KeyValuePair<int, int> item in Storage)
                            {
                                
                                FoundWords.Add(new KeyValuePair<int, int>(item.Key, item.Value));
    
                            }
                            //check to make sure board is not empty and checks if there is any islands
                            if (MainWindow.ValidPairs.Count != 0 && !IsConnect(Storage))
                            {
                                return -1;
                            }
                            
                            HorizontalWord = FrontWord.Substring(a, FrontLength - a) + MainLetter + BackWord.Substring(0, BackLength - b);
                            int points = CalculateScore(HorizontalWord);
                            TotalScore += points;
                            MainWindow.OutPutTextBox.AppendText("The word " + HorizontalWord + " is worth " + points + "\n");
                            MainWindow.OutPutTextBox.ScrollToCaret();


                        }
                    }
                }
               

            }
            //marking all letters in the hash table as true
            foreach (KeyValuePair<int, int> item in FoundWords)
            {

                UsedLetters[item.Key, item.Value] = true;
            }
            //checking to see if all letters placed on the board are used
            foreach(KeyValuePair<int, int> item in CoordinatePairs)
            {
                if(UsedLetters[item.Key, item.Value] == false)
                {
                    return -2;
                }
            }
            
           
            return TotalScore;
        }
        //calculates the points for each word scored and returns the score
        public static int CalculateScore(string word)
        {
            int Total = 0;
            for(int i=0; i<word.Length; i++)
            {
                Total += ScoreTable[word[i].ToString()];
            }
            return Total;
        }

        //switches to the computers turn
        public static void SwitchTurns()
        {

        }

        //if deck of tiles is empty its game over and the person with most points wins
        public static void GameOver()
        {

        }
        //checks if any part of the submitted word is connected to of the ValidPairs
        //returns true if there is a connection is found to the main island
        public static bool IsConnect(List<KeyValuePair<int, int>> Storage)
        {
            foreach(KeyValuePair<int, int> item in Storage)
            {
                foreach(KeyValuePair<int, int> Valid in MainWindow.ValidPairs)
                {
                    //if a connection is found to the main island then return true
                    if(item.Key==Valid.Key && item.Value== Valid.Value)
                    {
                        return true;
                    } 
                }
            }
            return false;
        }
       

        
    }
}