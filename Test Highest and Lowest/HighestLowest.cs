using System;
using System.Linq;

namespace Solution;
public static class Kata
{
    public static string HighAndLow(string numbers)
    {
        var numArr = numbers.Split().Select(int.Parse);
        return $"{numArr.Max()} {numArr.Min()}";
    }
}