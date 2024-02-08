
/*You are given an array prices where prices[i] is the price of a given stock on the ith day.

You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.*/

//https://www.youtube.com/watch?v=E2-heUEnZKU

public class Solution {
    public int MaxProfit(int[] prices) {
        // at the beginning the minimum price is the first price
        int buy_price = prices[0];
        // at the beginning the profit = 0
        int profit = 0;

        for(int i=0; i<prices.Length; i++){
            //if the current price is less then update the buy_price
            if(prices[i]<buy_price)
            {
                buy_price = prices[i];
            }
            else
            {
                // check if we can get a better profit
                int current_profit = prices[i] - buy_price;
                profit = Math.Max(current_profit, profit); 
            }
        }

        return profit;

    }
}
