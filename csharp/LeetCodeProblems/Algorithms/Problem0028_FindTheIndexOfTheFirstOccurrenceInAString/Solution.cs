using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0028_FindTheIndexOfTheFirstOccurrenceInAString
{
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            // return haystack.IndexOf(needle);

            for (int i = 0; i <= (haystack.Length - needle.Length); i++)
            {
                if (haystack.Substring(i, needle.Length) == needle)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
