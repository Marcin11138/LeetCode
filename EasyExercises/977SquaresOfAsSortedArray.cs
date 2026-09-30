class SquaresOfAsSortedArray
{
    static void Main(string[] args)
    {
        int[] nums = [-7, -3, 2, 3, 11];


        foreach (var item in MyFunction(nums))
        {
            System.Console.WriteLine(item);
        }
    }


}

// 16
// 1
// 0
// 9
// 100

//35ms, 65mb
//  static List<int> MyFunction(int[] nums)
//     {
//         List<int> list = new();

//         foreach (int number in nums)
//         {
//             list.Add(number * number);

//         }

//         list.Sort();
//         return list;
//     }

//28ms, 65mb
//A bit of optimalizing first solution, we are working now directly on nums instead of creating additional copy and using heavier List.
//   static int[] MyFunction(int[] nums)
//     {
//         for (int i = 0; i < nums.Length; i++)
//         {
//             nums[i] = nums[i] * nums[i];
//         }

//         Array.Sort(nums);

//         return nums;
//     }

//1ms, 65MB. 
// Instead of needing to use Sort, we directly put the biggest value on last position in array. It works because the array itself is in not-decreasing order so the biggest values are going to be 
// on  the beginning and on the end of array. 

// So if we have an array [1, 2, 3, 4 ,5] we set pointer at last array position, 
// then we check which candidate have higher value, the higher value is set on that position and we now take out the cadidate from the loop
// by running i++ (next candidate on the beginning of the array) 
// or by running end-- (next candidate from the end)
// after that, we look at the next caditate without last won candidate being in the loop.

//  static int[] MyFunction(int[] nums)
//     {
//         int[] newNumbers = new int[nums.Length];

//         int end = nums.Length - 1;
//         int position = end;
//         for (int i = 0; position >= 0;)
//         {
//             int squareNumber = nums[i] * nums[i];
//             int squareNumberEnd = nums[end] * nums[end];
//             if (squareNumber > squareNumberEnd)
//             {
//                 newNumbers[position] = squareNumber;
//                 position--;
//                 i++;

//             }
//             else
//             {
//                 newNumbers[position] = squareNumberEnd;
//                 position--;
//                 end--;

//             }

//         }

//         return newNumbers;
//     }