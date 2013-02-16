using System;


namespace _21.Combinations_of_K_distinct_elements
{
    class Combinations_of_K_distinct_elements
    {
        static void Main()
        {
            Console.Write("N=");
            int n = Convert.ToInt32(Console.ReadLine());

            int k = 0;
            do
            {
                Console.Write("K<N  K=");
                k = Convert.ToInt32(Console.ReadLine());

            } while ((k < 0) || (k > n));



            int[] arr = new int[k];

            for (int i = 0; i < k; i++)
            {
                arr[i] = i + 1;
            }



            while (true)
            {
                for (int i = 0; i < k; ++i)
                {
                    Console.Write("{0} ", arr[i]);
                }
                Console.WriteLine();

                int index = k - 1;
                bool stop = false;
                while (index >= 0)
                {
                    if (arr[index] < n - k + index + 1)
                    {
                        ++arr[index];
                        for (int i = index + 1; i < k; i++)
                        {
                            arr[i] = arr[index] + i - index;
                        }

                        break;
                    }
                    else
                    {
                        do
                        {
                            index--;
                        }
                        while (index >= 0 && arr[index] >= n - k + index + 1);


                        if (index >= 0)
                        {
                            arr[index]++;
                            for (int i = index + 1; i < k; i++)
                            {
                                arr[i] = arr[index] + i - index;
                            }
                        }
                        else
                        {
                            stop = true;
                        }
                        break;
                    }
                }

                if (stop)
                {
                    break;
                }
            }

        }
    }
}
