class ProductOfArrayExceptSelf
{
    static void Main(string[] args)
    {
        int[] nums = [1, 2, 3, 4];

        System.Console.WriteLine(MyFunction(nums)[0]);
    }

    static int[] MyFunction(int[] nums)
    {
        int length = nums.Length;
        int[] result = new int[length];

        int num = 1;
        for (int i = 0; i <= length - 1; i++)
        {
            result[i] = num;
            num = num * nums[i];
        }

        num = 1;
        foreach (int item in result)
        {
            System.Console.WriteLine("a" + item);
        }
        for (int i = length - 1; i >= 0; i--)
        {
            System.Console.WriteLine(result[i]+ " " + num);
    
            result[i] = result[i] * num;
            num = num * nums[i]; 
            
        }  
        return result;

    }
}


//1# solution
//Time Excedeed, raw solution
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

//2# attempt
//1ms, 62.42MB 100%, 77.91%
//We create left array at first which is saved in result. But we add an extra element at the beginning which is * 1.
//Then in next iteration, where we start from last position we add a * 1 element at last entry. 
//So the result[i] is always i - 1 (left) * i + 1 (right) as we added dummies at the start (or "end" on right side).
// static int[] MyFunction(int[] nums)
//     {
//         int length = nums.Length;
//         int[] result = new int[length];

//         int num = 1;
//         for (int i = 0; i <= length - 1; i++)
//         {
//             result[i] = num;
//             num = num * nums[i];
//         }

//         num = 1;
//         for (int i = length - 1; i >= 0; i--)
//         {
//             result[i] = result[i] * num;
//             num = num * nums[i]; 
            
//         }  
//         return result;

//     }