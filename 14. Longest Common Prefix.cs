/* Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "". */

public class Solution {
    public string LongestCommonPrefix(string[] strs) {

        StringBuilder result = new StringBuilder();

        //sort the array
        Array.Sort(strs);

        // i will check first and last strings
        char[] first = strs[0].ToCharArray();
        char[] last = strs[strs.Length-1].ToCharArray();

        // comparing part
        for(int i=0; i<first.Length; i++){
            if(first[i] != last[i])
            break;
            result.Append(first[i]);
        }
        return result.ToString();
    }
}
