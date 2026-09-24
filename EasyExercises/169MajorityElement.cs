using System.Collections;

class MajorityElement
{
    static void Main(string[] args)
    {
        int[] nums = [8, 7,8, 7, 7];

        System.Console.WriteLine(MyMethod(nums));
    }

    static int MyMethod(int[] nums)
    {
    
    }
}

//26ms, 62Mb
    // Hashtable hashtable = new();

    //     for (int i = 0; i < nums.Length; i++)
    //     {
    //         if (!hashtable.ContainsKey(nums[i]))
    //         {
    //             hashtable.Add(nums[i], 1);
    //         }
    //         else
    //         {
    //             hashtable[nums[i]] = (int)hashtable[nums[i]] + 1;
    //         }

    //     }

    //     int majority = 0;
    //     int majorityNumber = 0;
    //     foreach (DictionaryEntry item in hashtable)
    //     {
    //         if(majority < (int)item.Value)
    //         {
    //             majority = (int)item.Value;
    //             majorityNumber = (int)item.Key;
    //         }
    //     }
    //     return majorityNumber;
    
    //1114ms 62.86MB
    //Well This definietly wasnt the attempt. Exceptions are too expensive.
//       static int MyMethod(int[] nums)
//     {
//         Hashtable hashtable = new();
//         int majority = 0;
//         int majorityNumber = 0;
//         foreach (int number in nums)
//         {
//             try
//             {
//                 hashtable.Add(number, 1);
//                 if (nums.Length <= 1)
//                 {

//                     majorityNumber = number;
//                 }
//             }
//             catch
//             {
//                 hashtable[number] = (int)hashtable[number] + 1;

//                 if((int)hashtable[number] > majority)
//                 {
//                     majority = (int)hashtable[number];
//                     majorityNumber = number;
//                 }
//             }

            
//         }

//         return majorityNumber;
//     }
// }


//0ms, 47MB
//Not my solution, but it continue to seem like math solutions are best solutions. 
//On every move it checks if the candidate gets vote (so the number == candidate), if not take away vote (count--), when votes get to 0 change candidate to other (candidate == number)
//It ends on candidate that didnt "lost". The exercise always assume that the majority exists.
//Math algorithm name is "Boyer-Moore voting algorithm"

    // static int MyMethod(int[] nums)
    // {
    //     int candidate = 0;
    //     int count = 0;

    //     foreach( int number in nums)
    //     {
    //         if (count == 0)
    //         {
    //             candidate = number;
    //         }

    //         if (number == candidate)
    //         {
    //             count++;
    //         }
    //         else
    //         {
    //             count--;
    //         }
    //     }

    //     return candidate;
    // }