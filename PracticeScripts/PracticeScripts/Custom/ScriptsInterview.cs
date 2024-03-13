using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticeScripts.Custom
{
    public class ScriptsInterview
    {

        public Dictionary<int, int> GetGroup(int[] array)
        {
            //how many times each number is repeated in an array:
            Dictionary<int, int> result = new Dictionary<int, int>();
            var agrupar = array.GroupBy(v => v);
            foreach (var valores in agrupar)
                result[valores.Key] = valores.Count();

            return result;
        }
        public int MostCommon(int[] array, int k)
        {
            /*
            In the array, element 1 occurs once, 2 twice, 3 three times, 4 four times, and 5 five times, 
            making element 5 the most common element in the list and 4 the second most common element.
            For example: 
            int[] array = new int[]  { 5, 4, 3, 2, 1, 5, 4, 3, 2, 5, 4, 3, 5, 4, 5 };
            int key = 2; 
            result: return 4. 
             */
            var frecuencyMap = array.GroupBy(group => group)
                                .ToDictionary(group => group.Key, group => group.Count());

            var kthElement = frecuencyMap.OrderByDescending(x => x.Value)
                        .Select(s => s.Key)
                        .ElementAtOrDefault(k - 1);

            return kthElement;
        }
        public int SpartDemoInterview(int[] A)
        {

            for (int j = 0; j < A.Length - 1; j++)
                for (int x = 0; x < A.Length - 1; x++)
                {
                    if (A[x] > A[x + 1])
                    {
                        int r = A[x];
                        A[x] = A[x + 1];
                        A[x + 1] = r;
                    }
                }

            int elem = 1;
            for (int x = 0; x < A.Length - 1; x++)
            {
                if (A[x] > 0 && A[x] + 1 < A[x + 1])
                    return A[x] + 1;
                else if (A[x] == A.Length - 1 && A[x] > 0)
                    return A[x + 1] + 1;
            }

            return elem;
        }
        public int SpartInterview(string[] args)
        {
            if (args.Length == 0) return -1;

            int finalValue = 0;
            int x = 0;
            while (x < args.Length)
            {
                try
                {
                    switch (args[x].ToString().ToUpper())
                    {
                        case "--NAME":
                            if (args[x + 1].Length < 3 || args[x + 1].Length > 10)
                                return -1;
                            x = x + 2;
                            break;
                        case "--COUNT":
                            if (int.Parse(args[x + 1]) > 100 || int.Parse(args[x + 1]) < 10)
                                return -1;
                            x = x + 2;
                            break;
                        case "--HELP":
                            finalValue = 1;
                            x++;
                            break;
                        default:
                            return -1;
                    }
                }
                catch
                {
                    return -1;
                }
            }
            return finalValue;
        }

    }
}
