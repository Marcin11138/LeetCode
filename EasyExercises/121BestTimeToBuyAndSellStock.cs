class BestTimeToBuyAndSellStock
{
    static void Main(string[] args)
    {
        int[] prices = [7,5,3,6,4, 1];

        System.Console.WriteLine(BestDay(prices));
    }

//Much simpler solution, most gain is from not running two loops
    static int BestDay(int[] prices)
    {

        var profit = 0;
        var lowest = prices[0];

        for (int i = 0; i < prices.Length; i++)
        {
            profit = Math.Max(profit, prices[i] - lowest);
            lowest = Math.Min(prices[i], lowest);
        }




        return profit;
    }
};

//OLD

    //  var profit = 0;
    //     var lowest = 0;
       

    //     for (int i = 0; i < prices.Length; i++)
    //     {
            
    //         if (i +1 < prices.Length)
    //             {

    //             if (prices[i] < lowest || i == 0)
    //             {
    //                 System.Console.WriteLine("calc" + prices[i] + " " + lowest);
    //                 lowest = prices[i];
    //             }
    //             if(profit < prices[i + 1] - lowest)
    //             {
    //                 profit = prices[i + 1] - lowest;
    //             }
                
    //                 System.Console.WriteLine("profit " + profit);

    //             }
           

              
    //     }
    //     return profit;