using System;


namespace _11.Binary_search_alogrithm
{
    class Binary_Search_Algorithm
    {
        static int BinarySearch(int[] array, int searchedvalue, int left, int right)
        {
            if (right < left)
            {
                return -1;
            } // not found
            int mid = (left + right) / 2;
            if (array[mid] > searchedvalue)
            {
                return BinarySearch(array, searchedvalue, left, mid - 1);

            }
            else if (array[mid] < searchedvalue)
            {
                return BinarySearch(array, searchedvalue, mid + 1, right);
            }
            else return mid; // found
        }

        static void Main(string[] args)
        {
            int[] array = new int[30] { 2, 4, 6, 7, 8, 10, 13, 33, 44, 45, 47, 48, 49, 50, 51, 52, 53, 54, 56, 57, 58, 60, 63, 64, 65, 66, 67, 70, 72, 73 };
            Console.WriteLine(" 2, 4, 6, 7, 8, 10, 13, 33, 44,45,47,48,49,50,51,52,53,54,56,57,58,60,63,64,65,66,67,70,72,73 ");
            int searchedItem = int.Parse(Console.ReadLine());

            int left = 0;
            int right = 29;
            int result = BinarySearch(array, searchedItem, left, right);
            if (result == -1)
            {
                Console.WriteLine("No such number ");

            }
            else Console.WriteLine(result);
        }
    }
}
