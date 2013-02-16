using System;

namespace _03.Compare_two_char_arrays_lexicograhically
{
    class Compare_two_char_arrays
    {
        static void Main()
        {
            Console.Write("Array1=");
            string array1 = Console.ReadLine();
            Console.Write("Array2=");
            string array2 = Console.ReadLine();

            bool equal = false;

            for (int i = 0; i < Math.Min(array1.Length, array2.Length); i++)
            {
                if (array1[i] < array2[i])
                {
                    Console.WriteLine("Array 1 < Array 2 ");
                    break;
                }
                if (array1[i] > array2[i])
                {
                    Console.WriteLine("Array 1 > Array 2 ");
                    break;
                }

                if (array1[i] == array2[i] && array1.Length == array2.Length)
                {
                    equal = true;
                }
                else
                {
                    equal = false;
                    if (array1.Length > array2.Length)
                    {
                        Console.WriteLine("Array 1 > Array 2 ");
                    }
                    else Console.WriteLine("Array 1 < Array 2 ");
                    break;
                }
            }

            Console.WriteLine("Identical = {0}", equal);
        }
    }
}
