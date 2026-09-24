using System.Collections;

class FindAllNumbers
{
    static void Main(string[] args)
    {
        int[] nums = [2, 1, 2];

        Console.WriteLine(string.Join(",", MyMethod(nums)));
    }


    static List<int> MyMethod(int[] nums)
    {

    }
}


//First solution, 15ms, 72MB // 
    // static List<int> MyMethod(int[] nums)
    // {
    //     int numsLength = nums.Length;
    //     HashSet<int> hashset = new HashSet<int>(nums);

    //     List<int> outputArray = new();
    //     for (int i = 1; i <= numsLength; i++)
    //     {
    //         if (!hashset.Contains(i))
    //         {
    //             outputArray.Add(i);
    //         }
    //     }

    //     return outputArray;

    // }
    
    
//03ms, 75mb Second solution, faster and should be in practice much memory less heavy. Bits take much less memory, and the check returns  just the data of it with false/true instead of performing hash-table lookout with .Contains
// You can just use simple array of bool[] here. But it should use slightly more memory (bool uses 1byte of memory typicall and Bits use just a bit (1/8 of byte))
//         var bitArray = new BitArray(nums.Length + 1);
//         List<int> outputArray = new();

//         foreach (int num in nums)
//         {
//             bitArray[num] = true;
//         }

//         for (int i = 1; i <= nums.Length; i++)
//         {
//             if (!bitArray[i])
//                 outputArray.Add(i);
//         }

//         return outputArray;
