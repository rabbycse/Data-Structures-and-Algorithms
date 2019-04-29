
/* Given an unsorted array of inetgers, find a pair with given sum in it.

For example,

Input:

arr = [8,7,2,5,3,1]
sum = 10

Output:

Pair found at index 0 and 2 (8+2)
or
Pair found at index 1 and 4 (7+3)
*/

#include <stdio.h>

// Naive method to find a pair in an array with given sum
void findPair(int arr[], int n, int sum)
{
	// consider each element except last element
	for (int i = 0; i < n - 1; i++)
	{
		// start from i'th element till last element
		for (int j = i + 1; j < n; j++)
		{
			// if desired sum is found, print it and return
			if (arr[i] + arr[j] == sum)
			{
				printf("Pair found at index %d and %d", i, j);
				return;
			}
		}
	}
 
	// No pair with given sum exists in the array
	printf("Pair not found");
}
 
// Find pair with given sum in the array
int main()
{
	int arr[] = { 8, 7, 2, 5, 3, 1 };
	int sum = 10;
 
	int n = sizeof(arr)/sizeof(arr[0]);
 
	findPair(arr, n, sum);
 
	return 0;
}