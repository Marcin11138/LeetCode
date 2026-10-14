class MaximumAverageSubarray
{
    static void Main(string[] args)
    {
        int[] nums = [7,4,5,8,8,3,9,8,7,6];

        int k = 7;

        Console.WriteLine("result " + MyFunction(nums, k));
    }

   
}

// ???????ms, ???????MB
//First solution which time exceeded. which is understandable with the double loop on massive arrays of nums[] (O(n*k))
//The solution itself works, its just not optimal at all.
// static double MyFunction(int[] nums, int k)
//     {
//         int length = nums.Length;
//         long? maximumAvg = null;

//         for (int i = 0; i < length; i++)
//         {
//             int? localAvg = null;
//             if (!((i + k) >= length))
//             {
//                 for (int y = 0; y < k; y++)
//                 {
//                     if (localAvg == null)
//                     {
//                         localAvg = nums[i + 0];
//                         continue;
//                     }
//                     localAvg = localAvg + nums[i + y];

//                 }
//             }

//             if (maximumAvg == null || localAvg > maximumAvg)
//             {   

//                 maximumAvg = localAvg;
//             }
//         }

//         return (double)maximumAvg / k;
//     }

//2ms, 60MB
//Much better solution, instead of going again through same numbers we instead of everyiteration delete old number and add the new one. And we just check if sum of this is higher than old maxSum.
//Thats why its categorized as "window" exercise. 
//  static double MyFunction(int[] nums, int k)
//     {
//         int length = nums.Length;
//         long maxSum = 0;

//         long tempSum = 0;

//         for (int i = 0; i < k; i++)
//         {
//             tempSum = tempSum + nums[i];
//         }


//         maxSum = tempSum;
//         for (int i = k; i < length; i++)
//         {

//             tempSum = tempSum + nums[i] - nums[i - k];

            
//                 if (tempSum > maxSum)
//                 {
//                     maxSum = tempSum;

//                 }
             
            
            
            
            
//         }



//         return (double)maxSum / k;
//     }