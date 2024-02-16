using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeScripts.Arcade
{
    public class ExploringTheWaters
    {
        public int ArrayChange(int[] inputArray)
        {
            var max = inputArray[0];
            var moves = 0;
            for (var i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] <= max)
                {
                    moves += max - inputArray[i] + 1;
                    inputArray[i] = max + 1;
                }
                max = inputArray[i];
            }
            return moves;
        }
    }
}
