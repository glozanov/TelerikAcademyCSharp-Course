using System;


namespace _18.Print_remaining_sort_of_array
{
    class Print_remaining_sort_of_array
    {
        static void Main()
        {

            int[] a = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
            int n = a.Length;

            int[] lengthOfIncreasingSubsetEndingAt = new int[n];
            int[] previous = new int[n];
            int increasingSubsetLength = 0;
            int endOfSubset = -1;
            for (int i = 0; i < n; i++)
            {
                int lengthOfPrecedingIncrSubset = 0;
                previous[i] = -1;
                for (int j = 0; j < i; j++)
                {
                    if (a[j] < a[i])
                    {
                        if (lengthOfPrecedingIncrSubset < lengthOfIncreasingSubsetEndingAt[j])
                        {
                            lengthOfPrecedingIncrSubset = lengthOfIncreasingSubsetEndingAt[j];
                            previous[i] = j;
                        }
                    }
                }
                lengthOfIncreasingSubsetEndingAt[i] = lengthOfPrecedingIncrSubset + 1;
                if (lengthOfIncreasingSubsetEndingAt[i] > increasingSubsetLength)
                {
                    increasingSubsetLength = lengthOfIncreasingSubsetEndingAt[i];
                    endOfSubset = i;
                }
            }

            Console.WriteLine("Longest subsequence has length =" + increasingSubsetLength);
            int[] longestSubset = new int[increasingSubsetLength];
            int lastElement = endOfSubset;
            for (int index = increasingSubsetLength - 1; lastElement >= 0; index--)
            {
                longestSubset[index] = a[lastElement];
                lastElement = previous[lastElement];
            }
            for (int i = 0; i < increasingSubsetLength; i++)
            {
                Console.Write(longestSubset[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
