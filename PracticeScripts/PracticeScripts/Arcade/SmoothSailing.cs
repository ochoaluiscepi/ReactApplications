using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeScripts.Arcade
{
    public class SmoothSailing
    {
        public string[] AllLongestStrings(string[] inputArray)
        {
            int max = inputArray.Max(c => c.Length);
            return inputArray.Where(c => c.Length == max).ToArray();
        }
        public int CommonCharacterCount(string s1, string s2)
        {
            int elem = 0;
            foreach (char c in s1)
            {
                int index = s2.IndexOf(c);
                if (index >= 0)
                {
                    s2 = s2.Remove(index, 1);
                    elem++;
                }
            }
            return elem;
        }
        public bool IsLucky(int n)
        {
            string arr = n.ToString();
            int sum1 = 0; int sum2 = 0;
            if (arr.Length % 2 == 0)
            {
                int mid = arr.Length / 2;
                for (int x = 0; x < arr.Length; x++)
                    if (x < mid)
                        sum1 = sum1 + (int)arr[x];
                    else
                        sum2 = sum2 + (int)arr[x];
            }
            return sum1 == sum2;
        }
        public int[] SortByHeight(int[] a)
        {

            for (int x = 0; x < a.Length; x++)
            {
                if (a[x] > 0)
                {
                    for (int j = x + 1; j < a.Length; j++)
                    {
                        if (a[j] > 0)
                        {
                            if (a[x] > a[j])
                            {
                                int tem = a[x];
                                a[x] = a[j];
                                a[j] = tem;

                            }
                        }
                    }
                }
            }

            return a;
        }
        public string ReverseInParentheses(string inputString)
        {

            int count = inputString.Split('(').Length - 1;
            for (int x = 0; x <= count; x++)
            {
                int lid = inputString.LastIndexOf('(');

                if (lid == -1)
                {
                    return inputString;
                }
                else
                {

                    int rid = inputString.IndexOf(')', lid);

                    inputString =
                        inputString.Substring(0, lid) +
                        new string(inputString.Substring(lid + 1, rid - lid - 1).Reverse().ToArray()) +
                        inputString.Substring(rid + 1);
                }
            }
            return inputString;
        }
    }
}
