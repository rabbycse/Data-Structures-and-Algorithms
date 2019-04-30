
/** 
Given an array of inetgers, check if array contains sub-array having 0 sum.

 For example;

            Input: arr = [3, 4, -7, 3, 1, 3, 1, -4, -2, -2]

            Output: Subarray with 0 sum exists

            
            The sub-arrays with 0 sum are:
            {3, 4, -7}
            {4, -7, 3}
            {-7, 3, 1, 3}
            {3, 1, -4}
            {3, 1, 3, 1, -4, -2, -2}
            {3, 4, -7, 3, 1, 3, 1, -4, -2, -2}

 We can easily solve this problem in linear time by using hashing. The idea is to use set to check if sub-array with zero
 sum is present in the given array or not.We traverse the given array, and maintain sum of elements seen so far.If sum is
 seen before(i.e.sum exists in set),we return true as there exists at-least one sub-array with zero sum which ends at
 current index else we insert the sum into the set.
**/

using System;
using System.Collections.Generic;

namespace DSA
{
    public class Array
    {
        public static Boolean zeroSumSubarray(int[] A)
        {
            HashSet<int> set = new HashSet<int>(); 
            set.Add(0);

            int sum = 0;

            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];

                if (set.Contains(sum))
                {
                    return true;
                }

                set.Add(sum);
            }

            return false;
        }
        public static void Main(string[] args)
        {
            int[] A = { 4, -6, 3, -1, 4, 2, 7 };

            if (zeroSumSubarray(A))
            {
                Console.WriteLine("Subarray exists");
            }
            else
            {
                Console.WriteLine("Subarray do not exist");
            }
        }

    }
}
