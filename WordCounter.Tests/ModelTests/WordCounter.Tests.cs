using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter;

namespace WordCounter.Tests
{
    [TestClass]
    public class MatchWordTests
    {
        [TestMethod]
        public void GetSingleWord_StoreInputInString_SingleInput()
        {
            string userInput = "dog";
            RepeatCounter testRepeatCounter = new RepeatCounter("dog", "dog dog");
            Assert.AreEqual("dog", testRepeatCounter.RemoveSpacesandCharactersFromSingleWord(userInput));
        }

        [TestMethod]
        public void GetStringOfWords_StoreInputInString_MultipleInputs()
        {
            string userInput = "is your dog happy";
            RepeatCounter testRepeatCounter = new RepeatCounter("dog", "dog dog");
            Assert.AreEqual("is your dog happy", testRepeatCounter.RemoveCharactersFromStringWords(userInput));
        }

        [TestMethod]
        public void RemoveSpacesandCharactersFromSingleWord_TrueIfSpaces_int()
        {
            string userInput = "dog! ";
            RepeatCounter testRepeatCounter = new RepeatCounter("dog", "dog dog");
            Assert.AreEqual("dog", testRepeatCounter.RemoveSpacesandCharactersFromSingleWord(userInput));
        }

        [TestMethod]
        public void RemoveCharactersFromStringWords_TrueIfSpaces_int()
        {
            string userInput = "is your dog happ$y";
            RepeatCounter testRepeatCounter = new RepeatCounter("dog", "dog dog");
            Assert.AreEqual("is your dog happy", testRepeatCounter.RemoveCharactersFromStringWords(userInput));
        }

        [TestMethod]
        public void ConvertSingleWordToLowerCase_ReturnLowercase_string()
        {
            string userInput = "Dog";
            RepeatCounter testRepeatCounter = new RepeatCounter("dog", "dog dog");
            Assert.AreEqual("dog", testRepeatCounter.RemoveSpacesandCharactersFromSingleWord(userInput));
        }

        [TestMethod]
        public void ConvertStringOfWordsToLowerCase_ReturnLowercase_string()
        {
            string userInput = "Is Your Dog Happy";
            RepeatCounter testRepeatCounter = new RepeatCounter("dog", "dog dog");
            Assert.AreEqual("is your dog happy", testRepeatCounter.RemoveCharactersFromStringWords(userInput));
        }

        [TestMethod]
        public void Final_NumberOfInstances_int()
        {
            string userWord = "dog";
            string userWords = "is your dog happy";
            RepeatCounter testRepeatCounter = new RepeatCounter("dog", "dog dog");
            Assert.AreEqual(1, testRepeatCounter.Final(userWord, userWords));
        }
    }
}
