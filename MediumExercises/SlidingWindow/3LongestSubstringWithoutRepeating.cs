using System;
using System.Collections;
class LongestSubstringWithoutRepeating
{
    static void Main(string[] args)
    {
        string s = "baaabca";

        System.Console.WriteLine(MyFunction(s));


        if(args.Length > 0 && args[0] == "test")
        {
            int testResult;
            int expected;
            //test1
            testResult = MyFunction("abcabcbb");
            expected = 3;
            if (testResult == expected)
            {
                System.Console.WriteLine("Test 1 Pass. \nExpected: " + expected + " Got: " + testResult);
            }
            else
            {
                Console.WriteLine("Test 1 Fail. \nExpected: " + expected + " Got: " + testResult);
            }

            //test2
            testResult = MyFunction("eea");
            expected = 2;
            if (testResult == expected)
            {
                System.Console.WriteLine("Test 2 Pass. \nExpected: " + expected + " Got: " + testResult);
            }
            else
            {
                Console.WriteLine("Test 2 Fail. \nExpected: " + expected + " Got: " + testResult);
            }
            
            //test3
            testResult = MyFunction("pwwkew");
            expected = 3;
            if (testResult == expected)
            {
                System.Console.WriteLine("Test 3 Pass. \nExpected: " + expected + " Got: " + testResult);
            }
            else
            {
                Console.WriteLine("Test3 Fail. \nExpected: " + expected + " Got: " + testResult);
            }

            //test4
            testResult = MyFunction("baaabca");
            expected = 3;
            if (testResult == expected)
            {
                System.Console.WriteLine("Test 3 Pass. \nExpected: " + expected + " Got: " + testResult);
            }
            else
            {
                Console.WriteLine("Test3 Fail. \nExpected: " + expected + " Got: " + testResult);
            }


        }
    }

    
}

//1# attempt 
//229ms, 49.48MB 16.39%, 28.98%;
//We create hashtable, the hashtable have int which is the char and 2nd int which is the index.
//We convert string to char array. We create count and bestCount.
//We try to add the char to hashtable, if it dosnt exist we increment count by 1.
//If it returned false, it means that the char already exists in hashtable.
//First we check if the current count is bigger than the bestCount(start at 0) if it is we set bestCount = count.
//We set our pointer to the last instance of the character we are at which is duplicate.
//On next iteration it will be on next position in array.
//We reset our hashtable and we reset our count.

// static int MyFunction(string s)
//     {
//         IDictionary<int, int> hashtable = new Dictionary<int, int>();
//         char[] charArray = s.ToArray();
//         int count = 0;
//         int bestCount = 0;

//         if (charArray.Length == 1)
//         {
//             return 1;
//         }
        
//         for (int i = 0; i < charArray.Length; i++)
//         {

//             if (hashtable.TryAdd(charArray[i], i))
//             {
//                 count++;
//             }
//             else
//             {
//                 if (count > bestCount)
//                 {
//                     bestCount = count;
//                 }

//                 i = hashtable[charArray[i]];
//                 hashtable.Clear();
//                 count = 0;

//             }
//         }

//         if (count > bestCount)
//         {
//             bestCount = count;
//         }

//         return bestCount;
//     }

//2# Attempt
//58ms, 49.05MB 26.49%, 60.07%
//In this solution i moved from using hashtable to using the ASCII of char as the index in int array.
//The value is now the index of that character.
//Also you dont need to convert string to array, you can directly access the chars at indexes.
//If the value already exists, we go back by how many count we have currently. 
//If we find the same index as we are in currently on i loop, we set the i to the current y. On next iteration it starts again from +1.


// static int MyFunction(string s)
//     {
//         int[] charArray = new int[256];
        
//         int count = 0;
//         int bestCount = 0;

//         if (s.Length == 1)
//         {
//             return 1;
//         }

//         for (int i = 0; i < s.Length; i++)
//         {

//             if (charArray[s[i]] == 0 )
//             {
//                 charArray[s[i]] = s[i];
//                 count++;
//             }
//             else
//             {
//                 if (count > bestCount)
//                 {
//                     bestCount = count;
//                 }
//                 int y = 1;
                
//                 while(y <= count)
//                 {
//                     if (s[i - y] == s[i])
//                     {

//                         i = i - y;
//                         break;
//                     }
//                     y++;
//                 }

//                 count = 0;
//                 Array.Clear(charArray);

//             }   

//         }

//         if (count > bestCount)
//         {
//             bestCount = count;
//         }
        
//         return bestCount;
//     }
// }

//3#Solution 
//Here i tried to use BitArray instead of int array, it takes much less memory but it isnt faster.
// 83ms, 47.60MB 21.66%, 98.27%

//   static int MyFunction(string s)
//     {
//         BitArray charArray = new BitArray(256);

//         int count = 0;
//         int bestCount = 0;

//         if (s.Length == 1)
//         {
//             return 1;
//         }

//         for (int i = 0; i < s.Length; i++)
//         {

//             if (charArray[s[i]] == false)
//             {
//                 charArray[s[i]] = true;
//                 count++;
//             }
//             else
//             {

//                 if (count > bestCount)
//                 {
//                     bestCount = count;
//                 }
//                 int y = 1;

//                 while (y <= count)
//                 {
//                     if (s[i - y] == s[i])
//                     {

//                         i = i - y;
//                         break;
//                     }
//                     y++;
//                 }

//                 count = 0;
//                 charArray.SetAll(false);

//             }

//         }

//         if (count > bestCount)
//         {
//             bestCount = count;
//         }

//         return bestCount;
//     }
// }

//4# Solution
//48ms, 49.60MB 29.65%, 34.38%
//Here i got back again to int Array. I took out one of loops because we already know the position of last 
//So we dont need to go specific about of steps back first to get it, we still need to delete the already filled entries.


// static int MyFunction(string s)
//     {
//         int[] charArray = new int[256];
//         Array.Fill(charArray, -1);

//         int count = 0;
//         int bestCount = 0;

//         if (s.Length == 1)
//         {
//             return 1;
//         }

//         for (int i = 0; i < s.Length; i++)
//         {
//             if (charArray[s[i]] == -1)
//             {
//                 charArray[s[i]] = i;
//                 count++;
//             }
//             else
//             {
//                 if (count > bestCount)
//                 {
//                     bestCount = count;
//                 }

//                 int iTemp = i;
//                 i = charArray[s[i]];

//                 for (int y = count; y > 0; y--)
//                 {

//                     charArray[s[iTemp - y]] = -1;
//                 }
//                 count = 0;
//             }

//         }

//         if (count > bestCount)
//         {
//             bestCount = count;
//         }

//         return bestCount;
//     }

//5# Attempt
//30ms, 49.68Mb 63.82%, 34.38%
//Here we started saving the characters front of the old char that is same as current i.
//Its so we dont recheck same values again, we calculate the difference of count - difference of a and b. 
//We count the difference by iterating down from the i to when we hit the same value.
//Then we take out the chars from that point and we do count--;
//On next i increment, we will start from the same i but we will have all the chars that are before it already counted.

// public int LengthOfLongestSubstring(string s) {
//        int[] charArray = new int[256];


//         int count = 0;
//         int bestCount = 0;

//         if (s.Length == 1)
//         {
//             return 1;
//         }

//         for (int i = 0; i < s.Length; i++)
//         {

//             if (charArray[s[i]] == 0)
//             {
//                 charArray[s[i]] = i;
//                 count++;
//             }
//             else
//             {

//                 if (count > bestCount)
//                 {
//                     bestCount = count;
//                 }

//                 for (int y = 1; y <= count; y++)
//                 {
//                     if(s[i - y] == s[i])
//                     {
//                         int tempCount = count;
//                         for (int x = y; x <= tempCount; x++)
//                         {
//                             charArray[s[i - x]] = 0;
//                             count--;
//                         }

//                         charArray[s[i]] = i;
//                         count++;
//                         break;

//                     }
                    
//                 }
//             }

//         }

//         if (count > bestCount)
//         {
//             bestCount = count;
//         }

//         return bestCount;
//     }


//6# Solution
//12ms, 48.91MB 92.08%, 65.09%
//Here i started calulating difference of i and the old value by just calculating (i - lastIndexOfDuplicate)
//which gives us difference directly, and we can just run a loop that is taking out the rest out of count and 
//charArray.

// static int MyFunction(string s)
//     {
//         int[] charArray = new int[256];
//         Array.Fill(charArray, -1);

//         int count = 0;
//         int bestCount = 0;

//         if (s.Length == 1)
//         {
//             return 1;
//         }

//         for (int i = 0; i < s.Length; i++)
//         {
//             if (charArray[s[i]] == -1)
//             {
//                 count++;
//                 charArray[s[i]] = i;
//             }
//             else
//             {
//                 if (count > bestCount)
//                 {
//                     bestCount = count;
//                 }
                

//                 int lastIndexOfDuplicate = charArray[s[i]];
//                 count++;
//                 int countCopy = count;

//                 for (int y = 0; y < countCopy - (i - lastIndexOfDuplicate); y++)
//                 {

//                     charArray[s[lastIndexOfDuplicate - y]] = -1;
//                     count--;

//                 }
               
//                 charArray[s[i]] = i;

//             }
//         }

//         if (count > bestCount)
//         {
//             bestCount = count;
//         }

//         return bestCount;
//     }