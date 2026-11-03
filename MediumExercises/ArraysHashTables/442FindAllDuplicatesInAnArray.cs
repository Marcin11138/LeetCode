class FindAllDuplicatesInAnArray
{
    static void Main(string[] args)
    {
        int[] nums = [4, 3, 2, 7, 8, 2, 3, 1];

        System.Console.WriteLine(MyFunction(nums)[0]);
    }
     
  
}
    

//1# Attempt 
//19ms, 71.05MB 30.11%, 12.5%
//Simple solution with hashSet. 
//If we are not able to add a element to hashset because it already exists we add it to List result, at the end we return result.
//  static IList<int> MyFunction(int[] nums)
//     {
//         List<int> result = new();
//         HashSet<int> singleHashSet = new();

//         for (int i = 0; i < nums.Length; i++)
//         {
//             if (!singleHashSet.Add(nums[i]))
//             {
//                 result.Add(nums[i]);
//             }
//         }

//         return result;
//     }

//2# Attempt
//64ms, 69.18MB 9.09%, 67.61%
//This time sorted the nums and checked if next element value is the same as the current one, if it is we add it to list result..
//.. and we add a skip to loop (i++ add one step, and end of the iteration add another) as we dont need to check next value again. (Duplicates are limited to 2 in this exercise).
//It isnt faster because of the time the sort takes.
// static IList<int> MyFunction(int[] nums)
//     {
//         List<int> result = new();
//         Array.Sort(nums);
//         for (int i = 0; i < nums.Length -1; i++)
//         {
//             if(nums[i] == nums[i + 1])
//             {
//                 result.Add(nums[i]);
//                 i++;
//             }
//         }

//         return result;
//     }
// }

//3# Attempt
//2ms, 69.09MB 100%, 69.89%
//Because the nums array is 1...n and the numbers can be found only maximum twice, we can use the element values of nums as indexes.
//When we are at i position in nums, we take the value -1 ( -1 as array goes up from 0) and we treat it as index. We rewrite the value of that index to negative number of the value.
//If we find later a negative number on that index, we add it to result as it is duplicate. 
//It is faster than Attempt #1 as we have direct access to elements in nums by index, so we dont to search through hashset and wait for result of that seach or addition.

// static IList<int> MyFunction(int[] nums)
//     {
//         List<int> result = new List<int>(nums.Length /2);
        
//         for (int i = 0; i < nums.Length; i++)
//         {
//             int num = Math.Abs(nums[i]) - 1;

//             if (nums[num] < 0)
//             {

//                 result.Add(num +1);

//             }
//             else
//             {
//                 nums[num] = nums[num] * -1;

//             }

//         }

//         return result;
//     }
// }