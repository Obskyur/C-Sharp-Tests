using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Narcissistic_Number
{
    internal class NarcissisticNumber
    {
        public static bool isNarcissistic(int number)
        {
            string nums = number.ToString();

            //int pow = nums.Length, sum = 0;
            //foreach (var num in nums)
            //{
            //    sum += (int)Math.Pow(int.Parse(num.ToString()), pow);
            //    TestContext.Out.WriteLine(sum.ToString());
            //}
            //return sum == number;

            // Using Linq:
            return nums.Sum(c => Math.Pow(int.Parse(c.ToString()), nums.Length)) == number;
        }
    }
}
