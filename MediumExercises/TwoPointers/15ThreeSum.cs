using System.Collections;

class Sum
{
    static void Main(string[] args)
    {
        int[] nums = [0,0,0,0];
        // [-4, -1, -1, 0, 1 ,2]

        var result = MyFunction(nums);

        foreach (List<int> item in result)
        {

            System.Console.WriteLine(item[0] + " " + item[1] + " " + item[2]);
        }
    }

    static IList<IList<int>> MyFunction(int[] nums)
    {

        IList<IList<int>> result = new List<IList<int>>();
        HashSet<string> hashset = new();

        nums.Sort();

        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }
            int a = nums[i];

            int j = i + 1;
            int k = nums.Length - 1;

            while(j < k)
            {
                
                int sum = a + nums[j] + nums[k];
                if (sum == 0)
                {
                    string checkString = nums[i].ToString() + nums[j].ToString() + nums[k].ToString();

                    if (hashset.Add(checkString))
                    {
                        result.Add([nums[i], nums[j], nums[k]]);

                    }
                    j++;


                }
                else if (sum > 0)
                {
                    k--;
                }
                else if(sum < 0)
                {
                    
                    j++;
                }
            }   
        }

        return result;

    }
}

//1# Attempt
//Time Limit Exceeded
//Shamefull solution, it works but its definietly not optimized.
//Similar solution as in TwoSum, but instead we use difference between 0 from sum of a + b.
// static IList<IList<int>> MyFunction(int[] nums)
//     {
//         Dictionary<int, int> hashtable = new();
//         IList<IList<int>> result = new List<IList<int>>();
       
//         foreach (int num in nums)
//         {
//             if (!hashtable.ContainsKey(num))
//             {
//                 hashtable.Add(num, 1);
//             }
//             else
//             {
//                 hashtable[num] = hashtable[num] + 1;
//             }
//         }

//         for (int i = 0; i < nums.Length; i++)
//         {
           
//             int a = nums[i];

//             for (int y = 0; y < nums.Length; y++)
//             {
//                 if (i == y)
//                 {
//                     continue;
//                 }

//                 int b = nums[y];

//                 int sum = a + b;
//                 int difference = 0 - sum;

//                 if (hashtable.ContainsKey(difference))
//                 {
//                     if(difference == a && difference == b)
//                     {
//                         if(hashtable[a] < 3)
//                         {
//                             continue;
//                         }
//                     }
//                     else if (difference == a)
//                     {
//                         if (hashtable[a] < 2)
//                         {
//                             continue;
//                         }
                       
//                     }
//                     else if(difference == b)
//                     {
//                          if (hashtable[b] < 2)
//                         {
//                             continue;
//                         }
//                     }
                    
//                     List<int> tempList = new([a, b, difference]);
//                     tempList.Sort();

//                     bool duplicate = false;
//                     foreach (var item in result)
//                     {
//                         if (item[0] == tempList[0] && item[1] == tempList[1] && item[2] == tempList[2])
//                         {
//                             duplicate = true;
//                         }
//                     }
//                     if (duplicate == false)
//                     {
//                         result.Add(tempList);

//                     }
//                 }
//             }

//         }
        


//         return result;

//     }


//2# Attempt
//67ms, 72.75MB 21.71%, 5.27%
//This time we are sorting nums and iterating through it + two pointers with hashset for checking duplicates.

//We Create a hashset of string, as we will compare strings instead of checking all number separetly. 
//We iterate through nums, we set our first pointer as i + 1 so num front of i and the second pointer as nums.Length -1 so as last element in array. (array start as 0 so -1)
//We start a while loop with condition that j index isnt bigger than k index. 
//We sum through all elements at positions of indexes.
//We create 3 conditions, one if it is == 0, one if its below and one if its above 0. If the sum is below 0, we move our left j pointer +1 index, if its above we move k -1 index.
//If its 0, we convert our  numbers to one string and try to add it to hashset. If it added correctly (hashset return true or false) we add the numbers to result.
//On the end of ==0 we move our left pointer +1 index. 
//We return result.
//

// static IList<IList<int>> MyFunction(int[] nums)
//     {

//         IList<IList<int>> result = new List<IList<int>>();
//         HashSet<string> hashset = new();

//         nums.Sort();

//         for (int i = 0; i < nums.Length; i++)
//         {
//             if (i > 0 && nums[i] == nums[i - 1])
//             {
//                 continue;
//             }
//             int a = nums[i];

//             int j = i + 1;
//             int k = nums.Length - 1;

//             while(j < k)
//             {
                
//                 int sum = a + nums[j] + nums[k];
//                 if (sum == 0)
//                 {
//                     string checkString = nums[i].ToString() + nums[j].ToString() + nums[k].ToString();

//                     if (hashset.Add(checkString))
//                     {
//                         result.Add([nums[i], nums[j], nums[k]]);

//                     }
//                     j++;


//                 }
//                 else if (sum > 0)
//                 {
//                     k--;
//                 }
//                 else if(sum < 0)
//                 {
                    
//                     j++;
//                 }
//             }   
//         }

//         return result;

//     }