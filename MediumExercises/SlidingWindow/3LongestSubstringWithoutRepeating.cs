using System;
using System.Collections;
class LongestSubstringWithoutRepeating
{
    static void Main(string[] args)
    {
        string s = "pwwkew";

        System.Console.WriteLine(MyFunction(s));
    }

    static int MyFunction(string s)
    {
        int[] charArray = new int[256];
        Array.Fill(charArray, -1);

        int count = 0;
        int bestCount = 0;

        if (s.Length == 1)
        {
            return 1;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (charArray[s[i]] == -1)
            {
                count++;
                charArray[s[i]] = i;
            }
            else
            {
                if (count > bestCount)
                {
                    bestCount = count;
                }



                int lastIndexOfDuplicate = charArray[s[i]];
                int countCopy = count;
                for (int y = 0;  y <= countCopy - (i - lastIndexOfDuplicate); y++)
                {
                    charArray[s[lastIndexOfDuplicate - y]] = -1;
                    count--;
                }
                
                System.Console.WriteLine(i + " " +  lastIndexOfDuplicate);

            }
        }

        if (count > bestCount)
        {
            bestCount = count;
        }

        return bestCount;
    }
}

//1# attempt 
//229ms, 49.48MB 16.39%, 28.98%;

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

//#2 Attempt
//58ms, 49.05MB 26.49%, 60.07%

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
   
//                  count = 0;
  

//             }

//         }

//         if (count > bestCount)
//         {
//             bestCount = count;
//         }

//         return bestCount;
//     }

//#5 Attempt
//30ms, 49.68Mb 63.82%, 34.38%

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