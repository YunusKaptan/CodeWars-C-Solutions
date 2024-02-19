/*
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.
*/

      public class Solution {
        public bool IsPalindrome(string s) {
            
            //Converted the string to lowercase and remove non-alphanumeric characters
            s = s.ToLower();
            s = new string(s.Where(char.IsLetterOrDigit).ToArray());


            // i will get 2 pointers - left and right
            int left = 0;
            int right = s.Length - 1;

            while(left<right)
            
            if (s[left] == s[right])
            {
                left ++;
                right --;
            }
            else
            {
                return false;
            }
        
            return true;
        }
    }
