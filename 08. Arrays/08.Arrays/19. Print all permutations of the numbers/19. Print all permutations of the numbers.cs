using System;


namespace _19.Print_all_permutations_of_the_numbers
{
    class Print_all_permutation_of_the_numbers
    {
        static void Swap(ref int number1, ref int number2)
        {
            if (number1 != number2)
            {
                number1 = number1 ^ number2;
                number2 = number1 ^ number2;
                number1 = number1 ^ number2;
            }
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; ++i)
            {
                arr[i] = i + 1;
            }

            while (true)
            {
                for (int i = 0; i < n; ++i)
                {
                    Console.Write("{0} ", arr[i]);
                }
                Console.WriteLine();

                int index = n - 1;

                while (index > 0 && arr[index - 1] > arr[index])
                {
                    index--;
                }

                index--;

                if (index == -1)
                {
                    break;
                }

                {
                    int min = arr[index + 1];
                    int minIndex = index + 1;

                    for (int i = index + 1; i < n; ++i)
                    {
                        if (arr[i] < min && arr[i] > arr[index])
                        {
                            min = arr[i];
                            minIndex = i;
                        }
                    }

                    if (minIndex != index)
                    {
                        Swap(ref arr[index], ref arr[minIndex]);
                    }
                }

                index++;

                for (int i = index; i < n; i++)
                {
                    int min = arr[i];
                    int minPos = i;

                    for (int j = i + 1; j < n; j++)
                    {
                        if (arr[j] < min)
                        {
                            min = arr[j];
                            minPos = j;
                        }
                    }

                    if (minPos != i)
                    {
                        Swap(ref arr[i], ref arr[minPos]);
                    }
                }
            }
        }
    }
}
