using System;
using System.Collections.Generic;

namespace MadLibsGame.Models
{
    public class MadLibs
    {
        private string _occupation;
        private string _nounOne;
        private string _nounTwo;
        private string _nounThree;
        private string _nounFour;
        private string _adjectiveOne;
        private string _adjectiveTwo;
        private string _verbOne;
        private string _verbTwo;
        private string _verbThree;

        public string GetOccupation()
        {
            return _occupation;
        }

        public void SetOccupation(string newOccupation)
        {
            _occupation = newOccupation;
        }

        public string GetNounOne()
        {
            return _nounOne;
        }

        public void SetNounOne(string newNounOne)
        {
            _nounOne = newNounOne;
        }

        public string GetNounTwo()
        {
            return _nounTwo;
        }

        public void SetNounTwo(string newNounTwo)
        {
            _nounTwo = newNounTwo;
        }

        public string GetNounThree()
        {
            return _nounThree;
        }

        public void SetNounThree(string newNounThree)
        {
            _nounThree = newNounThree;
        }

        public string GetNounFour()
        {
            return _nounFour;
        }

        public void SetNounFour(string newNounFour)
        {
            _nounFour = newNounFour;
        }

        public string GetAdjectiveOne()
        {
            return _adjectiveOne;
        }

        public void SetAdjectiveOne(string newAdjectiveOne)
        {
            _adjectiveOne = newAdjectiveOne;
        }

        public string GetAdjectiveTwo()
        {
            return _adjectiveTwo;
        }

        public void SetAdjectiveTwo(string newAdjectiveTwo)
        {
            _adjectiveTwo = newAdjectiveTwo;
        }

        public string GetVerbOne()
        {
            return _verbOne;
        }

        public void SetVerbOne(string newVerbOne)
        {
            _verbOne = newVerbOne;
        }

        public string GetVerbTwo()
        {
            return _verbTwo;
        }

        public void SetVerbTwo(string newVerbTwo)
        {
            _verbTwo = newVerbTwo;
        }

        public string GetVerbThree()
        {
            return _verbThree;
        }

        public void SetVerbThree(string newVerbThree)
        {
            _verbThree = newVerbThree;
        }

    }
}
