using System;

namespace _04.Maximum_sequence_of_equal_elements
{
    class Maximum_sequence_of_equal_elements
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (uint i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            int searchedItem = array[0];
            int currentSequence = 1;
            int longestSequence = 1;
            int number = array[0];
            for (int i = 1; i < n; i++)
            {
                if (array[i] == searchedItem)
                {
                    currentSequence++;

                    if (i == n - 1 && longestSequence < currentSequence)
                    {
                        longestSequence = currentSequence;
                        number = array[i];
                    }
                }
                else
                {
                    if (longestSequence < currentSequence)
                    {
                        longestSequence = currentSequence;
                        number = array[i - 1];
                    }
                    currentSequence = 1;
                    searchedItem = array[i];

                }
            }
            Console.WriteLine(longestSequence);
            Console.WriteLine(number);

            Console.Write("{" + number);
            for (int i = 0; i < longestSequence - 1; i++)
            {
                Console.Write(",{0}", number);
            }
            Console.Write("}");
        }
    }
}
