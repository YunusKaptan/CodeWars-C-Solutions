
//You are climbing a staircase. It takes n steps to reach the top.

//Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
  
public class Solution {
    public int ClimbStairs(int n) {
        int[] data = new int[n+1];
        data[0]=1;
        data[1]=1;

        for(int index=2; index<=n; index++)
            data[index]= data[index-1]+data[index-2];

            return data[n];
        }
}
