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
        char[] charArray = s.ToArray();
        int count = 0;
        int bestCount = 0;

        if (charArray.Length == 1)
        {
            return 1;
        }

        for (int i = 0; i < charArray.Length; i++)
        {
            System.Console.WriteLine("a" + i);

            if (hashset.Add(charArray[i]))
            {

                count++;
            }
            else
            {


                if (count > bestCount)
                {
                    bestCount = count;
                }
                   

                for (int y = i - 1; y > 0 ; y--)
                {
                                    

                    if (charArray[y] == charArray[i])
                    {
                        // if (charArray[i - 1] == charArray[i])
                        // {
                        //     continue;
                        // }
                       
                        i = y + 1;
                            
                        
                        
                        // System.Console.WriteLine(i + " " + y);

                    }
                }

                hashset.Clear();
                count = 0;

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