class SumClosest
{
    static void Main(string[] args)
    {
        int[] nums = [10, 20, 30, 40, 50, 60, 70, 80, 90];
        int target = 1;

        System.Console.WriteLine(MyFunction(nums, target));
    }


}



//1# Attempt
//14ms, 42.18MB 64.37%, 89.33%
//Similar solution as to 15ThreeSum, but here we set a closest int and we rewrite it if the difference between target - sum is smaller.


// static int MyFunction(int[] nums, int target)
// {
//     nums.Sort();
//     int closest = nums[0] + nums[1] + nums[2];
//     int bestDifference = Math.Abs(target - closest);

//     for (int i = 0; i < nums.Length; i++)
//     {

//         int j = i + 1;
//         int k = nums.Length - 1;

//         while (j < k)
//         {
//             int sum = nums[i] + nums[j] + nums[k];
//             int difference = target - sum;

//             int oldDifference = target - closest;
//             if (Math.Abs(difference) < Math.Abs(oldDifference))
//             {
//                 closest = sum;
//             }

//             if (difference > 0)
//             {
//                 j++;
//             }
//             else if (difference < 0)
//             {
//                 k--;
//             }
//             else
//             {

//                 return closest;
//             }

//         }
//     }

//     return closest;
// }