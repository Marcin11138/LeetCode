class CointainerWithMostWater
{
    static void Main(string[] args)
    {
        int[] height = [1, 3, 2, 5, 25, 24, 5];

        System.Console.WriteLine(MyFunction(height));
    }


}

//1# Attempt
//1ms, 61.15MB 99.37%,68.53%
//Two pointers with greedy solution.
//We set our leftPointer on front of array, and our rightPointer at end of the array.
//We set our area with the first entries. We calculate area with (smaller of pointers) * (length between them);
//We set our while loop so it loops until the leftPointer dont get to rightPointer. 
//We get smaller number of our pointers, we calculate our length between them (pointerRight - pointerLeft), and we calculate our area of these.
//If our tempArea is bigger we rewrite the current area by it, if not the current area stays.

//Then we check which pointer is smaller, the smaller one increment by 1 (or decrement by 1 if rightPointer).
//On return we return area, which is the highest number we found.

// static int MyFunction(int[] height)
//     {
//         int length = height.Length - 1;

//         int area;
//         int pointerLeft = 0;
//         int pointerRight = length;
//         int smaller = height[pointerLeft] < height[pointerRight] ? height[pointerLeft] : height[pointerRight];

//         area = smaller * length;

//         while (pointerLeft < pointerRight)
//         {
           
//             int tempSmaller = height[pointerLeft] < height[pointerRight] ? height[pointerLeft] : height[pointerRight];
//             int currentLength = pointerRight - pointerLeft;
//             int tempArea = tempSmaller * currentLength;
            

//             if (tempArea > area)
//             {
//                 area = tempArea;
//             }

//             if (height[pointerLeft] < height[pointerRight])
//             { 
//                     pointerLeft++;
  
//             }
//             else
//             {
//                 pointerRight--;
//             }


//         }

//         return area;
//     }
    