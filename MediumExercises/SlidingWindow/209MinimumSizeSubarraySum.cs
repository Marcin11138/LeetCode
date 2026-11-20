class MinimumSizeSubarraySum
{
    static void Main(string[] args)
    {
        int target = 7;
        int[] nums = new int[] { 2, 3, 1, 2, 4, 3 };

        Console.WriteLine(MyFunction(nums, target));
    }

    static int MyFunction(int[] nums, int target)
    {
        int left = 0;
        int right = 1;
        int sum = nums[0];
        int minimalLength = 0;
        while(right > left)
        {


            if(sum >= target)
            {

                int length = right  - left;
                if (minimalLength == 0 || length < minimalLength)
                {
                    minimalLength = length;
                }
                sum = sum - nums[left];
                left++;

            }
            else if (sum < target)
            {
                

                     sum = sum + nums[right];
                    
                    right++;

                     if(right > nums.Length - 1)
                    {
                       break;
                    }
                

            }
            

            



        }


        return minimalLength;

    }
}