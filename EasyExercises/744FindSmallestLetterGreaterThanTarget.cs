class FindSmallestLetterGreaterThanTarget
{
    static void Main(string[] args)
    {
        char[] letters = ['c', 'f', 'j'];
        char target = 'a';

        System.Console.WriteLine(MyFunction(letters, target));
    }

    static char MyFunction(char[] letters, char target)
    {
        int low = 0;
        int high = letters.Length - 1;
        int lowest = 0;
        int charIndex = 0;
        bool isSet = false;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            int compare = letters[mid].CompareTo(target);

            if (compare >= 1)
            {
                if (isSet == false || lowest > compare)
                {
                    isSet = true;
                    charIndex = mid;
                    lowest = compare;
                }

                high = mid - 1;
            }

            if (compare <= 0)
            {
                low = mid + 1;
            }


        }

        return letters[charIndex];
    }
}


//0ms, 48.41MB 100%, 8.47%
//Low is from what point in array we look from, High is to what point we are looking.
// We are settings the ranges, on each iteration and checking if middle of the range is greater than target. If it is we are checking if its closer to the target
//than the old value that is currently there. If it is we rewrite it and save the charIndex. We search through the whole array, so the last value is going to be the
//closest one to the target. If there isnt any greater char in array, we dont overwrite the default 0 and we get array[0] as the response.

//On first iteration if the compare result is bigger than 1, the default lowest = 0 cant be smaller, so we are using isSet to set the first value.



//  int low = 0;
        // int high = letters.Length - 1;
        // int lowest = 0;
        // int charIndex = 0;
        // bool isSet = false;

        // while (low <= high)
        // {
        //     int mid = low + (high - low) / 2;
        //     int compare = letters[mid].CompareTo(target);

        //     if (compare >= 1)
        //     {
        //         if (isSet == false || lowest > compare)
        //         {
        //             isSet = true;
        //             charIndex = mid;
        //             lowest = compare;
        //         }

        //         high = mid - 1;
        //     }

        //     if (compare <= 0)
        //     {
        //         low = mid + 1;
        //     }


        // }

        // return letters[charIndex];