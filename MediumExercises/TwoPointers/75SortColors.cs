class SortColors
{
    static void Main(string[] args)
    {
        int[] nums = [0, 1, 2, 0];
        //

        MyFunction(nums);
        foreach (int item in nums)
        {
            System.Console.WriteLine(item);
        }
    }

   
}

//1# Attempt
//1ms, 46.66MB 14.19%, 13.64%
//Simplest sorting implementation.
//2 Loops i and y, i is the left pointer y is the right pointer.
//we find the smallest number that can be on position i with y on every i iteration, y iterator check all the numbers.
//y iterator runs until it its at the same position as i.
// static void MyFunction(int[] nums)
//     {


//         for (int i = 0; i < nums.Length; i++)
//         {
//             for (int y = nums.Length - 1; y > i; y--)
//             {
//                 if (nums[y] < nums[i])
//                 {
//                     int tempCopy = nums[i];
//                     nums[i] = nums[y];
//                     nums[y] = tempCopy;
//                 }
//             }
//         }

//     }

//2# Attempt
//0ms, 46.01MB 100%, 50.67%
//In this solution we are moving 0 and 2, 0 on front (left) 2 on back(right).
//1 stays in place which 
//  static void MyFunction(int[] nums)
//     {

//         int left = 0;
//         int pointer = 0;
//         int right = nums.Length - 1;

//         while(pointer <= right)
//         {

//             if (nums[pointer] == 0)
//             {
                
//                 int temp = nums[left];
//                 nums[left] = nums[pointer];
//                 nums[pointer] = temp;

//                 left++;
//                 pointer++;
//             }
//             else if (nums[pointer] == 1)
//             {
//                 pointer++;
//             }
//             else
//             {
//                 int temp = nums[right];
//                 nums[right] = nums[pointer];
//                 nums[pointer] = temp;

//                 right--;
//             }
//         }
        
//     }