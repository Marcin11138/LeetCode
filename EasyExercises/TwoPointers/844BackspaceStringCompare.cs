class BackspaceStringCompare
{
    static void Main(string[] args)
    {
        string s = "ab##";
        string t = "c#d#";

        Console.WriteLine(MyFunction(s, t));
    }

    static bool MyFunction(string s, string t)
    {

    }
}

//5ms, 40.96MB
// static bool MyFunction(string s, string t)
//     {
//         int backspaces = 0;
//         char[] sCharArray = s.ToCharArray();
//         char[] tCharArray = t.ToCharArray();

//         for (int i = sCharArray.Length - 1; i >= 0; i--)
//         {
//             if (sCharArray[i] == '#')
//             {

//                 backspaces++;
//                 sCharArray[i] = ' ';

//             }
//             else if (backspaces > 0)
//             {
//                 sCharArray[i] = ' ';
//                 backspaces--;
//             }

//         }

//         backspaces = 0;
//         for (int i = tCharArray.Length - 1; i >= 0; i--)
//         {

//             if (tCharArray[i] == '#')
//             {
//                 backspaces++;
//                 tCharArray[i] = ' ';

//             }
//             else if (backspaces > 0)
//             {

//                 tCharArray[i] = ' ';
//                 backspaces--;

//             }

//         }

//         string filteredSChars = new string(sCharArray.Where(ch => ch != ' ').ToArray());
//         string filteredTChars = new string(tCharArray.Where(ch => ch != ' ').ToArray());

//         if (filteredSChars == filteredTChars)
//         {
//             return true;
//         }
//         return false;
//     }


//1ms, 41mb
// Second solution, instead of editing the arrays of chars, we instead just add the non-removed chars to list and insert them at the beginning of it. 
// When filtering we dont need to iterate through full char array again.
//  int backspaces = 0;
//         char[] sCharArray = s.ToCharArray();
//         char[] tCharArray = t.ToCharArray();
//         List<char> sCharList = new();
//         List<char> tCharList = new();


//         for (int i = sCharArray.Length - 1; i >= 0; i--)
//         {
//             if (sCharArray[i] == '#')
//             {
//                 backspaces++;
//                 continue;
//             }
//             else if (backspaces > 0)
//             {
//                 backspaces--;
//                 continue;
//             }

//             sCharList.Insert(0, sCharArray[i]);
//         }
//         backspaces = 0;
//         for (int i = tCharArray.Length - 1; i >= 0; i--)
//         {
//             if (tCharArray[i] == '#')
//             {
//                 backspaces++;
//                 continue;
//             }
//             else if (backspaces > 0)
//             {
//                 backspaces--;
//                 continue;
//             }

//             tCharList.Insert(0, tCharArray[i]);
//         }
//         string a = new string(sCharList.ToArray());
//         string b = new string(tCharList.ToArray());

//         System.Console.WriteLine(b);
//         if (a == b)
//         {
//             return true;
//         }
//         return false;


//0ms, 41MB
//Solution 3. Instead of iterating through the list to get a string we first check if the number of elements is the same if it is
//we continue and check each element in list with element in other list.
//If its not the same we return false. If every check didnt return false, we just return true.

//Its much faster this way as we always need to iterate through the list, but that way we can get if something isnt the same much earlier through iteration.

//          int backspaces = 0;
//         char[] sCharArray = s.ToCharArray();
//         char[] tCharArray = t.ToCharArray();
//         List<char> sCharList = new();
//         List<char> tCharList = new();

//         for (int i = sCharArray.Length - 1; i >= 0; i--)
//         {
//             if (sCharArray[i] == '#')
//             {
//                 backspaces++;
//                 continue;
//             }
//             else if (backspaces > 0)
//             {
//                 backspaces--;
//                 continue;
//             }

//             sCharList.Insert(0, sCharArray[i]);
//         }
//         backspaces = 0;
//         for (int i = tCharArray.Length - 1; i >= 0; i--)
//         {
//             if (tCharArray[i] == '#')
//             {
//                 backspaces++;
//                 continue;
//             }
//             else if (backspaces > 0)
//             {
//                 backspaces--;
//                 continue;
//             }
//             tCharList.Insert(0, tCharArray[i]);
//         }
        
//         int sListCount = sCharList.Count;
//         int tListCount = tCharList.Count;

//         if(sListCount != tListCount){
//             return false;
//         }

//         for (int i = 0; i < sListCount; i++){
//             if(sCharList[i] != tCharList[i]){
//                 return false;
//             }
//         }
//         return true;

  