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

        
        public string RemoveSpacesandCharactersFromSingleWord(string word)
        {
            char[] charsToTrim = { ',', '{', ' ', '~', '`', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '=' };
            string singleInputWithoutCharacters = word.Trim(charsToTrim).ToLowerInvariant();
            SetCleanWord(singleInputWithoutCharacters);
            return singleInputWithoutCharacters;
        }

        public string RemoveCharactersFromStringWords(string list)
        {
            string[] chars = new string[] { ",", ".", "/", "!", "@", "#", "$", "%", "^", "&", "*", "'", "\"", ";", "_", "(", ")", ":", "|", "[", "]" };
            for (int i = 0; i < chars.Length; i++)
            {
                if (list.Contains(chars[i]))
                {
                    list = list.Replace(chars[i], "");
                }
            }
            SetCleanList(list.ToLowerInvariant());
            return list;
        }

        //public string ConvertSingleWordToLowerCase(string word)
        //{
        //    string lowerCaseInputOne = word.ToLowerInvariant();
        //    return lowerCaseInputOne;
        //}

        //public string ConvertStringOfWordsToLowerCase(string list)
        //{
        //    string lowerCaseInputTwo = list.ToLowerInvariant();
        //    return lowerCaseInputTwo;
        //}

        public int Final(string word, string list)
        {

            var arr = list.Split(new char[] { ' ', '.', ',', ';', ':', '?', '!' });
            var count = Array.FindAll(arr, s => s.Equals(word.Trim())).Length;
            return count;

        }
    }
}