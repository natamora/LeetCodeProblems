using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0012_IntegerToRoman
{
    public class Solution
    {
        public string IntToRoman(int num)
        {
            var result = new StringBuilder();
            var dict = new List<(int, string)>
            {
                ( 1000, "M" ),
                ( 900, "CM" ),
                ( 500, "D" ),
                ( 400, "CD" ),
                ( 100, "C" ),
                ( 90, "XC" ),
                ( 50, "L" ),
                ( 40, "XL" ),
                ( 10, "X" ),
                ( 9, "IX" ),
                ( 5, "V" ),
                ( 4, "IV" ),
                ( 1, "I" )
            };

            foreach (var (number, symbol) in dict)
            {
                while (num >= number) {
                    result.Append(symbol);
                    num -= number;
                }
            }
            return result.ToString();
        }
    }
}
