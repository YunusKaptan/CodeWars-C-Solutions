/* 
In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.

Examples
Kata.HighAndLow("1 2 3 4 5");  // return "5 1"
Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"

*/

//Solution

using System;
using System.Linq;

public static class Kata
{
  public static string HighAndLow(string numbers)
  {
    var num = numbers.Split().Select(int.Parse);
    return $"{num.Max()} {num.Min()}";
  }
}
