using System;
using System.Collections.Generic;



namespace _15.Sieve_of_Eratosthenes_Algorithm
{
    class Sieve_of_eratosthenes_Algorithm
    {
        static void Main()
        {
            //int[] numbers = new int[100000];
            //for (int i = 0; i < 100000; i++)
            //{
            //    numbers[i] = i;
            //}
            //numbers[1] = 0;

            //for (int i = 2; i < 100000; i++)
            //{
            //    if (numbers[i] != 0)
            //    {
            //        int number = numbers[i];
            //        for (int j = i + 1; j < 100000; j++)
            //        {

            //            if (numbers[j]%number==0)
            //            numbers[j] = 0;
            //        }

            //    }
            //}

            //for (int i = 0; i < 100000; i++)
            //{
            //    if (numbers[i] != 0)
            //    {
            //        Console.Write( "{0} ",numbers[i] );
            //    }
            //}

            List<int> numbers = new List<int>();
            int divider = 1;
            numbers.Add(2);
            for (int i = 3; i < 1000000; i = i + 2)
            {
                numbers.Add(i);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] != 1 & divider <= Math.Sqrt(1000000))
                {
                    divider = numbers[i];

                }
                else continue;
                for (int j = i + 1; j < numbers.Count; j++)
                {

                    if (numbers[j] % divider == 0)
                        numbers[j] = 1;
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] != 1) Console.WriteLine("{0} ", numbers[i]);
            }






        }
    }
}
