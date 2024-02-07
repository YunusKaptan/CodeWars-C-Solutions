/*Given an array nums of size n, return the majority element.

The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.*/

//https://www.youtube.com/watch?v=wD7fs5P_MVo
public class Solution {
    public int MajorityElement(int[] nums) {
        int majority = nums[0], votes =1;
        for (int i=1; i<nums.Length; i++){
            if(votes==0){
                votes++;
                majority=nums[i];
            }
            else if(majority==nums[i]){
                votes++;
            }
            else
            votes--;
        }
        return majority;
        }
    }
