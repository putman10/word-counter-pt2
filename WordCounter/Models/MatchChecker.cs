using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounter
    {

        private string _singleWord;
        private string _listOfWords;
        private static List<RepeatCounter> _jobListings = new List<RepeatCounter>() { };

        public void UpdateList()
        {
            _jobListings.Add(this);
        }

        public List<RepeatCounter> GetList()
        {
            return _jobListings;
        }

        public string GetSingleWord()
        {
            return _singleWord;
        }

        public void SetSingleWord(string newSingleWord)
        {
            _singleWord = newSingleWord;
        }

        public string GetListOfWords()
        {
            return _listOfWords;
        }

        public void SetListOfWords(string newListOfWords)
        {
            _listOfWords = newListOfWords;
        }
        
        public string RemoveSpacesandCharactersFromSingleWord(string inputOne)
        {
            char[] charsToTrim = { ',', '{', ' ', '~', '`', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '=' };
            string singleInputWithoutCharacters = inputOne.Trim(charsToTrim);
            ConvertSingleWordToLowerCase(singleInputWithoutCharacters);
            return singleInputWithoutCharacters;
        }

        public string RemoveCharactersFromStringWords(string inputTwo)
        {
            string[] chars = new string[] { ",", ".", "/", "!", "@", "#", "$", "%", "^", "&", "*", "'", "\"", ";", "_", "(", ")", ":", "|", "[", "]" };

            for (int i = 0; i < chars.Length; i++)
            {
                if (inputTwo.Contains(chars[i]))
                {
                    inputTwo = inputTwo.Replace(chars[i], "");
                }
            }
            ConvertStringOfWordsToLowerCase(inputTwo);
            return inputTwo;
        }

        public string ConvertSingleWordToLowerCase(string inputOne)
        {
            string lowerCaseInputOne = inputOne.ToLowerInvariant();
            return lowerCaseInputOne;
        }

        public string ConvertStringOfWordsToLowerCase(string inputTwo)
        {
            string lowerCaseInputTwo = inputTwo.ToLowerInvariant();
            return lowerCaseInputTwo;
        }

        public int Final(string inputOne, string inputTwo)
        {

            var arr = inputTwo.Split(new char[] { ' ', '.', ',', ';', ':', '?', '!' });
            var count = Array.FindAll(arr, s => s.Equals(inputOne.Trim())).Length;
            return count;

        }
    }
}