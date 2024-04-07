using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_IsPrime
{
    public static class Kata
    {
        public static bool IsPrime(int n)
        {
            if (n < 2) return false;
            //for (int i = 2; i * i <= n; i++)
            //{
            //    if (n % i == 0)
            //        return false;
            //}
            //return true;

            // Using Linq:
            return Enumerable.Range(2, (int)Math.Sqrt(n)-1).All(divisor => n % divisor != 0);
        }
    }
}
