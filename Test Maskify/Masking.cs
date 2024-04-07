using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Maskify
{
    public static class Kata
    {
        public static string Maskify(string cc)
        {
            // Guard for small string:
            if (cc.Length <= 4) return cc;

            // Using StringBuilder:
            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < cc.Length - 4; i++)
            //{
            //    sb.Append('#');
            //}
            //sb.Append(cc.TakeLast(4).ToArray());
            //return sb.ToString();

            // Using String methods:
            return cc.Substring(cc.Length - 4).PadLeft(cc.Length, '#');
        }
    }
}
