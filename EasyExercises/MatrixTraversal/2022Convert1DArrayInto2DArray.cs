class Convert1DArrayInto2DArray
{
    static void Main(string[] args)
    {
        int[] original = [1, 2, 3, 4];
        int m = 2;
        int n = 2;


        System.Console.WriteLine(MyFunction(original, m, n)[1][0]);
    }

    
}

//1# solution
//2ms, 66.04MB, 100%, 58.62%
//First we get length of original array, then we count total number of elements we need for it to be able to fully fill the arrays. 
//If the length of original is different then totalAmount of elements, we return [];
// We create a arrayList we will return, the exercise will have jagged array as return [][] so we set it to new int[m(total amount of columns)][(unkown amount of elements in row)]
//We set our pointers now, mPos and nPos and a temporary array of ints.
// We iterate through our original array length, if nPos is smaller than it should, we add a original element to tempArray if after adding it and running nPos++
//the nPos == nPos (If total elements is at the amount it should be)
// We add the array at position of mPos(which start at 0)
//We clean our array, reset our nPos
//and we add 1 to mPos, as we want now to touch next column

// static int[][] MyFunction(int[] original, int m, int n){

//         int length = original.Length;
//         int totalAmount = m * n;

//         if (totalAmount != length)
//         {
//             return [];
//         }

//         int[][] arrayList = new int[m][];

//         int mPos = 0;
//         int nPos = 0;
//         int[] tempArray = new int[n];

//         for (int i = 0; i < length; i++)
//         {
//             if (nPos < n)
//             {
//                 tempArray[nPos] = original[i];
//                 nPos++;

//                 if (nPos == n)
//                 {
//                     arrayList[mPos] = tempArray;
//                     tempArray = new int[n];
//                     nPos = 0;
//                     mPos++;
//                 }
//             }   
//         }

//         return arrayList;
//     }



