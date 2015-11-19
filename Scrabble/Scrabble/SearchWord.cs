using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Scrabble
{
    class SearchWord
    {
        public static Dictionary<string, int> wordList; //Holds words defined in text file
        public SearchWord()
        {
            
            
        }

        public static void MakeDictionary()
        {
            wordList = new Dictionary<string, int>();
            var data = File.ReadAllLines("Content/words.txt"); //Reads in all data from file

            for (int i = 0; i < data.Length; i++)              //Adds to Dictionary
                wordList.Add(data[i], i);

        }

        public static bool ValidWord(string word) //If word in dictionary, return true, else false
        {
            return (wordList.ContainsKey(word));
        }
    }
}
