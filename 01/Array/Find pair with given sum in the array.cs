
/** 
Given an unsorted array of inetgers, find a pair with given sum in it.

 For example;

            Input:

            arr = [8,7,2,5,3,1]
            sum = 10

            Output:

            Pair found at index 0 and 2 (8+2)
            or
            Pair found at index 1 and 4 (7+3)
**/

using System;

namespace DSA
{
    public class Array
    {
        public static void findPair(int[] A, int sum)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] + A[j] == sum)
                    {
                        Console.WriteLine("Pair found at index "
                                        + i + " and " + j);
                        return;
                    }
                }
            }

            Console.WriteLine("Pair not found");
        }
        public static void Main(string[] args)
        {
            int[] A = { 8, 7, 2, 5, 3, 1 };
            int sum = 10;

            findPair(A, sum);
        }

    }
}
