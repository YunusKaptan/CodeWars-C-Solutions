/*
Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

Each letter in magazine can only be used once in ransomNote.
*/

public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        var list = new List<char>(ransomNote);
        var counter = 0;
        foreach (var element in magazine)
        {
            if (list.Remove(element))
            {
                counter++;
            }
        }
        return ransomNote.Length == counter;
    }
}
