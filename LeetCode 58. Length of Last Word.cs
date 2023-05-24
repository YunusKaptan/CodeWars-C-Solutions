/*
Given a string s consisting of words and spaces, return the length of the last word in the string.

A word is a maximal 
substring
 consisting of non-space characters only.

 

Example 1:

Input: s = "Hello World"
Output: 5
Explanation: The last word is "World" with length 5.
Example 2:

Input: s = "   fly me   to   the moon  "
Output: 4
Explanation: The last word is "moon" with length 4.
Example 3:

Input: s = "luffy is still joyboy"
Output: 6
Explanation: The last word is "joyboy" with length 6.
 

Constraints:

1 <= s.length <= 104
s consists of only English letters and spaces ' '.
There will be at least one word in s.
*/

    public class Solution {
    public int LengthOfLastWord(string s) 
    {
        // now we will remowe all spaces with trim !
        s = s.Trim();
        int length = 0;
        int lastIndex = s.Length-1;

        // Start read from Right to Left.
        for(int i = lastIndex; i >= 0; i--)
        {
            if(s[i]== ' ')
            {
                break;
            }

            length ++;

        }

        return length;
        
    }
}
