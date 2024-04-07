using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Expanded_Number
{
    public static class Kata
    {
        public static string ExpandedForm(long num)
        {
            // Using StringBuilder:
            //StringBuilder sb = new StringBuilder();
            //int place = 1;
            //while (num > 0)
            //{
            //    int digit = (int)(num % 10);
            //    if (digit != 0)
            //    {
            //        sb.Insert(0, $"{digit}".PadRight(place, '0') + (sb.Length > 0 ? " + " : ""));
            //    }
            //    place++;
            //    num /= 10;
            //}
            //return sb.ToString();

            // Using Linq:
            var str = num.ToString();
            return String.Join(" + ",
                str
                // Convert all characters to their digit value * 10^currentPlaceLength
                .Select((x, i) => int.Parse(x.ToString().PadRight(str.Length - i - 1, '0')))
                //char.GetNumericValue(x) * Math.Pow(10, str.Length - i - 1))
                // Filter out zero values
                .Where(x => x > 0)
                );
        }
    }
}
