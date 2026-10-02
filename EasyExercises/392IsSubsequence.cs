class IsSubsequence
{
    static void Main(string[] args)
    {
        string s = "abc";
        string t = "ahbgdc";

        Console.WriteLine(MyFunction(s, t));
    }

    static bool MyFunction(string s, string t)
    {

        return false;
    }
}

//0ms, 41.81MB
//First and final solution.
//Standard two points, we take strings to array. First pointer points always the first value in s array, if the second pointer in f iteration find same element,
//we look at next char in s pointer. through iteration if the elements counted is same as the s length we return true early.
//The 2nd pointer is always going to be longer.

        // int tLength = t.Length - 1;

        // char[] sArray = s.ToCharArray();
        // char[] tArray = t.ToCharArray();

        // int counted = 0;
        // int lastPosition = 0;

        // if(s.Length == 0){
        //     return true;
        // }
        // for (int i = 0; i <= tLength; i++)
        // {
            
        //     if (tArray[i] == sArray[lastPosition])
        //     {
        //         lastPosition++;
        //         counted++;

        //         if (counted == s.Length)
        //         {
        //             return true;
        //         }

        //     }


        // }
        //     return false;