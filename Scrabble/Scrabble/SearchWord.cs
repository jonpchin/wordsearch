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
        private Dictionary<string, int> wordList; //Holds words defined in text file
        public SearchWord()
        {
            wordList = new Dictionary<string, int>();
            MakeDictionary();
        }

        public void MakeDictionary()
        {
            var data = File.ReadAllLines("Content/words.txt"); //Reads in all data from file

            for (int i = 0; i < data.Length; i++)              //Adds to Dictionary
                wordList.Add(data[i], i);

        }

        public bool ValidWord(string word) //If word in dictionary, return true, else false
        {
            return (wordList.ContainsKey(word));
        }
    }
}
