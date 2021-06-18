using System;
using System.Collections.Generic;
// ref: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/

public class Example
{
    public static void differentWayOfArrayInitialize()
    {
        // Declare a single-dimensional array of 5 integers.
        int[] array1 = new int[5];

        // Declare and set array element values.
        int[] array2 = new int[] { 1, 3, 4, 5, 6 };

        // Alternative syntax.
        int[] array3 = { 1, 2, 3, 4, 5, 6 };

        // Declare a two dimensional array as object.
        int[,] multiDimensionalArray1 = new int[2, 3];

        // Declare and set array element values.
        int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

        // Declare a jagged array.
        int[][] jaggedArray = new int[6][];

        // Set the values of the first array in the jagged array structure.
        jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
    }

    public static void passingArrayAsArgumnets(int[] arrays)
    {
        foreach (int array in arrays)
        {
            Console.WriteLine(array);
        }
    }

    public static void Main()
    {
        int[] arrays = new int[] { 1, 2, 3, 4, 5, 6 };
        passingArrayAsArgumnets(arrays);
    }
}
