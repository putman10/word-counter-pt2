using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounter
    {

        private string _singleWord;
        private string _listOfWords;
        private string _singleClean;
        private string _listClean;
        private int _matches;

        public RepeatCounter(string word, string list)
        {
            this.SetSingleWord(word);
            this.SetListOfWords(list);
        }

        public void SetSingleWord(string word)
        {
            _singleWord = word;
        }

        public string GetSingleWord()
        {
            return _singleWord;
        }

        public void SetListOfWords(string list)
        {
            _listOfWords = list;
        }

        public string GetListOfWords()
        {
            return _listOfWords;
        }

        public void SetCleanWord(string word)
        {
            _singleClean = word;
        }

        public string GetCleanWord()
        {
            return _singleClean;
        }

        public void SetCleanList(string list)
        {
            _listClean = list;
        }

        public string GetCleanList()
        {
            return _listClean;
        }

        public void SetMatches(int matches)
        {
            _matches = matches;
        }

        public int GetMatches()
        {
            return _matches;
        }


        public string RemoveSpacesandCharactersFromSingleWord()
        {
            char[] charsToTrim = { ',', '{', ' ', '~', '`', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '=' };
            string singleInputWithoutCharacters = _singleWord.Trim(charsToTrim).ToLowerInvariant();
            SetCleanWord(singleInputWithoutCharacters);
            return singleInputWithoutCharacters;
        }

        public string RemoveCharactersFromStringWords()
        {
            string[] chars = new string[] { ",", ".", "/", "!", "@", "#", "$", "%", "^", "&", "*", "'", "\"", ";", "_", "(", ")", ":", "|", "[", "]" };
            for (int i = 0; i < chars.Length; i++)
            {
                if (_listOfWords.Contains(chars[i]))
                {
                    _listOfWords = _listOfWords.Replace(chars[i], "");
                }
            }
            SetCleanList(_listOfWords.ToLowerInvariant());
            return _listClean.ToLowerInvariant();
        }


        public int Final()
        {
            RemoveCharactersFromStringWords();
            RemoveSpacesandCharactersFromSingleWord();
            var arr = _listClean.Split(new char[] { ' ', '.', ',', ';', ':', '?', '!' });
            var count = Array.FindAll(arr, s => s.Equals(_singleClean.Trim())).Length;
            SetMatches(count);
            return count;
        }
    }
}
