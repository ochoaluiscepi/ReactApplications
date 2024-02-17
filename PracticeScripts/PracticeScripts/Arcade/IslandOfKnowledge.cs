using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeScripts.Arcade
{
    public class IslandOfKnowledge
    {
        public int AvoidObsdtacles(int[] inputArray)
        {
            int[] arrOrder = inputArray.OrderBy(e => e).ToArray();
            for (int x = 1; x < arrOrder.Max()+x; x++)
            {
                for (int j = x; j <= 1000 + arrOrder.Length; j = j + x)
                {
                    if (arrOrder.Where(c => c == j).Count() > 0)
                        break;

                    if (j > arrOrder.Max())
                        return x;
                }
            }
            return 0;
        }
        public bool isIPV4Address(string inputString)
        {
            string[] arr = inputString.Split('.');
            if (arr.Length != 4)
                return false;

            foreach (string elem in arr)
            {
                if (int.TryParse(elem, out int ip))
                {
                    if (ip < 0 || ip >= 256 || (elem.StartsWith('0') && elem.Length > 1))
                        return false;
                }
                else
                    return false;
            }
            return true;
        }
    }
}
