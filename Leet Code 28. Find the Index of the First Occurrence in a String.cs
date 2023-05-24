/*
Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

 

Example 1:

Input: haystack = "sadbutsad", needle = "sad"
Output: 0
Explanation: "sad" occurs at index 0 and 6.
The first occurrence is at index 0, so we return 0.
Example 2:

Input: haystack = "leetcode", needle = "leeto"
Output: -1
Explanation: "leeto" did not occur in "leetcode", so we return -1.
*/


public class Solution {
    public int StrStr(string haystack, string needle) 
    {
        if (string.IsNullOrEmpty(needle))
            return 0;
        
        int haystackLength = haystack.Length;
        int needleLength = needle.Length;
        
        for (int i = 0; i <= haystackLength - needleLength; i++) {
            if (haystack[i] == needle[0]) {
                int j;
                for (j = 1; j < needleLength; j++) {
                    if (haystack[i + j] != needle[j])
                        break;
                }
                if (j == needleLength)
                    return i;
            }
        }
        
        return -1;
    }
}
