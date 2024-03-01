using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticeScripts.Custom
{
    public class ScriptsInterview
    {

        public Dictionary<int, int>  GetGroup(int[] array)
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
                        .ElementAtOrDefault(k-1);

            return kthElement;
        }

    }
}
