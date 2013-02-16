using System;


namespace _09.Most_frequent_number_in_an_array
{
    class Most_Frequent_Number_in_an_array
    {
        static void Main()
        {
            int[] array = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 2, 2, 4, 9, 3 };

           

            int searchedElement = array[0];
            int frequentelement = array[0];
            int count = 1;
            int maxCount = 0;
            uint j = 0;
            for (uint i = 1; i < array.Length; i++)
            {

                for (j = i; j < array.Length; j++)
                {
                    if (array[j] == searchedElement)
                    {
                        count++;

                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    frequentelement = searchedElement;
                }
                searchedElement = array[i];
                count = 1;
            }

            Console.WriteLine("{0} ({1} times)", frequentelement, maxCount);
            // Console.ReadLine();
        }
    }
}
