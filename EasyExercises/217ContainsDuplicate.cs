using System.Collections;
using System.Globalization;

class ContainsDuplicate
{
    static void Main(string[] args)
    {

        int[] nums = [1, 2, 3, 1];

        Console.WriteLine(haveDuplicate(nums));


    }

    static bool haveDuplicate(int[] nums)
    {
        //Last attempt, the differences between this and last ones are just noise. 14ms/78MB
        HashSet<int> hashset = new HashSet<int>();

        foreach (int number in nums)
        {
           if (!hashset.Add(number))
            {
                return true;
            } 
        }

        return false;
        
    }
}
//First version // 76ms 92mb
    // static bool haveDuplicate(int[] nums)
    // {
    //     Hashtable hashtable = new();

    //     for (int i = 0; i < nums.Length; i++)
    //     {
    //         if (hashtable.ContainsKey(nums[i]))
    //         {
    //             return true;
    //         }
    //         hashtable.Add(nums[i], i);

    //     }

    //     return false;
    // }   
    

//Second version, used HashSet instead because the exercise didnt have use for values, so it is a bit faster and lighter // 16ms 78mb
    //    HashSet<int> hashtable = new HashSet<int>();

    //     for (int i = 0; i < nums.Length; i++)
    //     {
    //         if (hashtable.Contains(nums[i]))
    //         {
    //             return true;
    //         }
    //         hashtable.Add(nums[i]);

    //     }

    //     return false;
    // }

//Attempt third, the if instead add the nums[i] to the hashSet and when it cant it add it because the number already exists it return true (duplicate)
//Suprisingly for me not much faster, 16ms, 78MB same as last attempt
// static bool haveDuplicate(int[] nums)
//     {
//           HashSet<int> hashset = new HashSet<int>();

//         for (int i = 0; i < nums.Length; i++)
//         {
//             if (!hashset.Add(nums[i]))
//             {
//                 return true;
//             }

//         }

//         return false;
        
//     }