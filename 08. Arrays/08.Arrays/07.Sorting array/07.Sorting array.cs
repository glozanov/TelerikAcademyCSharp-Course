using System;


namespace _07.Sorting_array
{
    class Sorting_Array
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (uint k = 0; k < n; k++)
            {
                array[k] = int.Parse(Console.ReadLine());

            }
            int j = 0;
            int min, temp;
            int i = 0;
            for (i = 0; i < n - 1; i++)
            {
                min = i;

                for (j = i + 1; j < n; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

        }
    }
}