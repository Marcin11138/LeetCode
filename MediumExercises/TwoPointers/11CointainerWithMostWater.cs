class CointainerWithMostWater
{
    static void Main(string[] args)
    {
        int[] height = [1, 8, 6, 2, 5, 4, 8, 3, 7];

        System.Console.WriteLine(MyFunction(height));
    }
    
    static int MyFunction(int[] height)
    {
        int leftPointer = 0;
        int rightPointer = height[height.Length - 1];
        int leftSum = 0;
        int rightSum = 0;

        int bestLeft = 0;
        
        int prevHeightLeft = height[0];

        for (int i = 0; i < height.Length - 1; i++)
        {
            if (height[i] > prevHeightLeft)
            {
                if (height[i] > leftSum)
                {
                    leftSum = height[i];
                    bestLeft = i;
                }
            }
            else
            {
            leftSum = leftSum + height[i];
                
            }



        }
        return leftSum;
        for (int y = height.Length - 1; y > 0; y--)
        {
            
        }


    }
}