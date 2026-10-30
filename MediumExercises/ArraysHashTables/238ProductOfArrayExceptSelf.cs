class ProductOfArrayExceptSelf
{
    static void Main(string[] args)
    {
        int[] nums = [1, 2, 3, 4];

        System.Console.WriteLine(MyFunction(nums)[3]);
    }

    static int[] MyFunction(int[] nums)
    {
        int length = nums.Length - 1;
        int[] result = new int[length];

        int num = 1;
        for (int i = 0; i <= length; i++)
        {
            result[i] = num;
            num = num * nums[i];
        }

        num = 1;
        for (int i = length; i >= length; i--)
        {
            result[i] = result[i] * num;
            num = num *  
        }
          
        return result;

    }
}


//1# solution
//Time Excedeed, raw thinking
// static int[] MyFunction(int[] nums)
//     {
//         int[] result = new int[nums.Length];
//         for (int i = 0; i < nums.Length; i++)
//         {
//             int? sum = null;

//             for (int y = 0; y < nums.Length; y++)
//             {
//                 if (sum == null && y != i)
//                 {
//                     sum = nums[y];
//                 }
//                 else if (y != i)
//                 {
//                     sum = sum * nums[y];
//                 }
//             }

//             result[i] = (int)sum;
//         }

//         return result;
        
//     }