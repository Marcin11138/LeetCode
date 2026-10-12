class BinarySearch
{
    static void Main(string[] args)
    {
        int[] nums = [-1, 0, 3, 5, 6, 7, 8, 9];
        int target = 9;

        System.Console.WriteLine(MyFunction(nums, target));
    }

    static int MyFunction(int[] nums, int target)
    {
      
    }
}


//0ms, 53.43MB. 100%, 9.21%
//First solution. Binary search, we half our search array until the middle is the number we search for. If the array cant be halved anymore, we return -1. 
// As the number was not found.

//  int low = 0;
//         int high = nums.Length - 1;


//         while (low <= high)
//         {
//             int middle = low + (high - low) / 2;

//             if (nums[middle] == target)
//             {
//                 return middle;
//             }

//             if (nums[middle] < target)
//             {
//                 low = middle + 1;
//             }
//             else if (nums[middle] > target)
//             {
//                 high = middle - 1;
//             }

//         }


//         return -1;