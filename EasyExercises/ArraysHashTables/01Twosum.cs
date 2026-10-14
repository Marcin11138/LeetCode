

using System.Collections;

class Twosum
{

    static void Main(string[] args)
    {
        int[] nums = [1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1];
        int target = 11;

        var response = TwoSum(nums, target);
        Console.WriteLine(string.Join(" ", response));
    }
    static int[] TwoSum(int[] nums, int target)
    {
        IDictionary<int, int> dictionary = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int secondNumber = target - nums[i];
            if (dictionary.ContainsKey(secondNumber))
            {
                return new int[] { dictionary[secondNumber], i };
            }
            dictionary[nums[i]] = i; 

        }

        return [];
    }
}


//First version, raw thinking


        // for (int i = 0; i < nums.Length; i++)
        // {
        //     for (int y = i + 1; y < nums.Length;  y++)
        //     {

          
        //         if (nums[i] + nums[y] == target)
        //         {
        //             return [i, y];
        //         }
        //     }
        // }

        // return [];


//After rethinking, and searching for better solutions

    // Hashtable hashtable = new Hashtable();
    //     for(int i = 0; i < nums.Length; i++)
    //     {
    //         int complement = target - nums[i];
            
            
    //         if (hashtable.ContainsKey(complement))
    //         {

    //             return new int[] {(int)hashtable[complement], i};
    //         }
    //         hashtable[nums[i]] = i;
    //     }

    //     return [];