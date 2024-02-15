using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeScripts.Arcade
{
    public class EdgeOfTheOcean
    {
        public int AdjacentElementsProduct(int[] inputArray)
        {
            return inputArray.Select((i, j) => j > 0 ? i * inputArray[j - 1] : int.MinValue).Max();
        }
        public int ShapeArea(int n)
        {
            return n * n + ((n - 1) * (n - 1));
        }
        public int MakeArrayConsecutive(int[] statues)
        {
            for (int x = 0; x < statues.Length - 1; x++)
                for (int i = 0; i < statues.Length - 1; i++)
                    if (statues[i] > statues[i + 1])
                    {
                        int statueVal = statues[i];
                        statues[i] = statues[i + 1];
                        statues[i + 1] = statueVal;
                    }

            int Acum = 0;
            //[2,3,6,8]
            for (int x = 0; x < statues.Length - 1; x++)
                if ((statues[x + 1] - statues[x]) != 1)
                    Acum = Acum + ((statues[x + 1] - statues[x]) - 1);

            //return statues.Max() - statues.Min() - statues.Length + 1;

            return Acum;
        }
        public bool AlmostIncreasingSequence(int[] sequence)
        {
            if (sequence.Length == 2) { return true; }
            int countOne = 0, countTwo = 0;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] >= sequence[i + 1])
                    countOne++;

                if (i != 0)
                    if (sequence[i - 1] >= sequence[i + 1])
                        countTwo++;
            }

            if (countOne == 1 && countTwo <= 1)
                return true;
            else
                return false;

        }
        public int MatrixElementsSum(int[][] matrix)
        {
            int r = 0;
            for (int i = 0; i < matrix[0].Length; i++)
                for (int j = 0; j < matrix.Length && matrix[j][i] > 0; j++)
                    r += matrix[j][i];

            return r;
        }
    }
}
