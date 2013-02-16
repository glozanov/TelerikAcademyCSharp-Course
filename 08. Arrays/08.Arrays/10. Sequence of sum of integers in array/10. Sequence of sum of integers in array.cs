using System;


namespace _10.Sequence_of_sum_of_integers_in_array
{
    class Sequence_of_sum_of_integers_in_array
    {
        static void Main()
        {
            int searchedSum = int.Parse(Console.ReadLine());
            uint n = uint.Parse(Console.ReadLine());

            int[] array = new int[n];
            uint i = 0;
            for (i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }


            int sum = 0;
            uint j = 0;
            string sequence = "";

            for (i = 0; i < n; i++)
            {
                sum = array[i];
                sequence = Convert.ToString(array[i]);
                if (sum == searchedSum) Console.WriteLine(sequence + " sum= " + sum);
                for (j = i + 1; j < n; j++)
                {
                    sum += array[j];
                    sequence = sequence + "," + Convert.ToString(array[j]);

                    if (sum == searchedSum)
                    {
                        Console.WriteLine(sequence + " sum= " + sum);


                    }

                }


            }


        }
    }
}