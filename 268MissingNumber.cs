class MissingNumber
{
    static void Main(string[] args)
    {
        int[] nums = [0, 1];

        Console.WriteLine(MyMethod(nums));
    }

    static int MyMethod(int[] nums)
    {

        int n = nums.Length; 
        int expected = n * (n + 1) / 2;
        int actual = 0;
        for (int i = 0; i <= nums.Length; i++)
        {
            actual = actual + nums[i];
        }

        return expected - actual;
    }
}

// 5ms, 47.02MB First solution, 
// static int MyMethod(int[] nums)
//     {
//         int expected = 0;
//         int actual = nums.Sum();
//         for (int i = 0; i <= nums.Length; i++)
//         {
//             expected = expected + i;
//         }

//         return expected - actual;
//     }

//3ms, 47.29MB
// Second solution, a bit faster. Instead of running for loop we calculate the expected number by using mathemathical formula (number * number(number +1) /2). Didnt find the formula myself, but i did read about it to understand it.
// There are a bit faster solutions for it, but i think this one is really simple and straight forward. 
    // public int MissingNumber(int[] nums) {
    //     int n = nums.Length; 
    //     int expected = n * (n + 1) / 2;
    //     int actual = nums.Sum();

    //     return expected - actual;
    // }