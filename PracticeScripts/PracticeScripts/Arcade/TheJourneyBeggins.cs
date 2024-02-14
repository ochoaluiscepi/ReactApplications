using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PracticeScripts.Arcade
{
    public class TheJourneyBeggins
    {
        public int CenturyFromYear(int year)
        {
            return year % 100 == 0 ? year / 100 : ((100 - year % 100) + year) / 100;
        }
        public int Add(int param1, int param2)
        {
            return param1+param2;
        }
        public bool CheckPalindrome(string inputString)
        {
            return inputString.SequenceEqual(inputString.Reverse());
        }
    }
}
