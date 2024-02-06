//Write a function that returns a string in which firstname is swapped with last name.


public class Kata
{   
  public static string NameShuffler(string str)
  {
    string[] token = str.Split(' ',2);
    return $"{token[1]} {token[0]}";
  }
}
