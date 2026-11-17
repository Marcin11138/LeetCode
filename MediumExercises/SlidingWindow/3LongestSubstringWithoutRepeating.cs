class LongestSubstringWithoutRepeating
{
    static void Main(string[] args)
    {
        string s = "abcabcbb";

        System.Console.WriteLine(MyFunction(s));
    }

    static int MyFunction(string s)
    {
        HashSet<int> hashset = new();
        
        int count = 0;
        int bestCount = 0;

        if (s.Length == 1)
        {
            return 1;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (hashset.Add(s[i]))
            {
                count++;
            }
            else
            {

                if (count > bestCount)
                {
                    bestCount = count;
                }
                int y = 1;
                
                while(y <= count)
                {
                    if (s[i - y] == s[i])
                    {

                        i = i - y;
                        break;
                    }
                    y++;
                }

                count = 0;
                hashset.Clear();

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
// +