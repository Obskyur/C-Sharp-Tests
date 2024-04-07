using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Greed
{
    internal class Kata
    {
        public static int Score(int[] dice)
        {
            //int result = 0;
            //int[] freq = new int[6];
            //foreach (var die in dice)
            //{
            //    freq[die - 1]++;
            //}
            //for (int i = 0; i < freq.Length; i++)
            //{
            //    switch (i)
            //    {
            //        case 0:
            //            result += freq[i] >= 3
            //                ? 1000 + (freq[i] - 3) * 100
            //                : freq[i] * 100; 
            //            break;
            //        case 4:
            //            result += freq[i] >= 3
            //                ? 500 + (freq[i] - 3) * 50
            //                : freq[i] * 50;
            //            break;
            //        default:
            //            result += freq[i] / 3 * (i + 1) * 100;
            //            break;
            //    }
            //}
            //return result;

            // Using Linq:
            return Enumerable.Range(1, 6)
                .Sum(die => 
                    dice.Count(roll => roll == die) / 3 * (die == 1 ? 1000 : die * 100) 
                    + 
                    dice.Count(roll => roll == die) % 3 * (die == 1 ? 100 : (die == 5 ? 50 : 0))
                );
        }
    }
}
