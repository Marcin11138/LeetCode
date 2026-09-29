class MoveZeroes
{
    static void Main(string[] args)
    {
        int[] nums = [1, 0, 0, 0, 1];


        foreach (var item in MyFunction(nums))
        {
            System.Console.WriteLine(item);
        }
    }

    static int[] MyFunction(int[] nums)
    {
    }  
}

// 52ms, 58MB
//First Version 
// static int[] MyFunction(int[] nums)
// {

//     for (int i = 0; i < nums.Length; i++)
//     {
//         if (nums[i] == 0)
//         {
//             int index = nums.IndexOf(nums[i]);
//             for (int y = i + 1; y < nums.Length; y++)
//             {

//                 if (nums[y] != 0)
//                 {
//                     int save = nums[y];
//                     nums[index] = nums[y];

//                     nums[y] = 0;
//                     index = nums.IndexOf(nums[y]);

//                 }

//             }
//         }
//     }

//     return nums;


// }


//45ms, 58MB
//Second version, took out one loop as i can just use the first one to calculate y, im also looping to position nums.Length - 1 as the last position will be already swapped from y + 1.
// static int[] MyFunction(int[] nums)
//     {

//         for (int i = 0; i < nums.Length -1; i++)
//         {
//             int y = i + 1;
//             if (nums[i] == 0)
//             {
//                 int index = nums.IndexOf(nums[i]);

//                     if (nums[y] != 0)
//                     {
//                         int save = nums[y];
//                         nums[index] = nums[y];

//                         nums[y] = 0;
//                         index = nums.IndexOf(nums[y]);

//                     }


//             }
//         }

//         return nums;


//     }


// 21ms, 58MB
//y and index are now nested deeper, so they run only when they are needed.
//We dont really need to save[y], and we dont really need to rewrite index at end.
// static int[] MyFunction(int[] nums)
// {

//     for (int i = 0; i < nums.Length - 1; i++)
//     {
//         if (nums[i] == 0)
//         {
//             int y = i + 1;

//             if (nums[y] != 0)
//             {
//                 int index = nums.IndexOf(nums[i]);

//                 nums[index] = nums[y];
//                 nums[y] = 0;

//             }
//         }
//     }

//     return nums;


// }
// }

//1ms, 58MB
//4th and final version
//Instead of swapping position of 0 further into array, we instead swap non zeros closer, on zeroes positions. The zeros naturally end up at the end. 
// static int[] MyFunction(int[] nums)
//     {
//         int left = 0;

//         for (int right = 0; right < nums.Length; right++)
//         {


//             if (nums[right] != 0)
//             {
//                 int temp = nums[right];


//                 nums[right] = nums[left];

//                 nums[left] = temp;
//                 left++;

//             }

//         }

//         return nums;


//     }