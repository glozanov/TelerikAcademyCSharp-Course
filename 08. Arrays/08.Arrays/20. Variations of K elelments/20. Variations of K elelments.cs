using System;

namespace _20.Variations_of_K_elelments
{
    class Variation_of_K_elements
    {
        static void Main()
        {
            Console.Write("N=");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("K=");
            int k = Convert.ToInt32(Console.ReadLine());




            int[] arr = new int[k];

            for (int i = 0; i < k; i++)
            {
                arr[i] = 1;
            }

            while (true)
            {
                for (int i = 0; i < k; i++)
                {
                    Console.Write("{0} ", arr[i]);
                }
                Console.WriteLine();

                int index = k - 1;
                bool stop = false;
                while (index >= 0)
                {
                    if (arr[index] < n)
                    {
                        arr[index]++;
                        break;
                    }
                    else
                    {
                        do
                        {
                            index--;
                        }
                        while (index >= 0 && arr[index] == n);


                        if (index >= 0)
                        {
                            for (int i = index + 1; i < k; i++)
                            {
                                arr[i] = 1;
                            }
                            arr[index]++;
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
