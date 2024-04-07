using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Create_Phone_Number
{
    internal class PhoneNumber
    {
        public static string Create(int[] numbers)
        {
            TestContext.Out.WriteLine(int.Parse(string.Concat(numbers)));
            // Using a format specifier:
            TestContext.Out.WriteLine($"{int.Parse(string.Concat(numbers)):(000) 000-0000}");
            // Using ToString(IFormatSpecifier) method:
            TestContext.Out.WriteLine(int.Parse(string.Concat(numbers)).ToString("(000) 000-0000"));

            return $"{int.Parse(string.Concat(numbers)):(000) 000-0000}";
        }
    }
}
