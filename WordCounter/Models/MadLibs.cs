using System;
using System.Collections.Generic;

namespace MadLibsGame.Models
{
    public class MadLibs
    {
        private string _occupation;
        private string _nounOne;


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
    }
}
