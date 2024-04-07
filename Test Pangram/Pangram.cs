using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Pangram
{
    public static class Kata
    {
        public static bool IsPangram(string str)
        {
            // Using Linq:
            //return Enumerable.All(
            //    Enumerable.Range('a', 'z' - 'a' + 1).Select(c => (char)c),
            //    c => str.ToLower().Contains(c)
            //);

            // Simplified using .Where():
            return str.ToLower().Where(ch => Char.IsLetter(ch)).Distinct().Count() == 26;
        }
    }
}
