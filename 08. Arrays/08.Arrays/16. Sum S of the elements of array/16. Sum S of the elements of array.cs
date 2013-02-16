using System;
using System.Collections.Generic;

namespace _16.Sum_S_of_the_elements_of_array
{
    class Sum_S_of_elements_of_array
    {
        static void Main()
        {


            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int sum = 0, s = 13;


            bool check = false;
            int limit = (int)(Math.Pow(2, arr.Length) - 1);
            Stack<int> stack = new Stack<int>(arr.Length);
            for (int i = 0; i < limit; i++)
            {
                sum = 0;
                stack.Clear();

                for (int j = 0; j < arr.Length; j++)
                {
                    if (((i >> j) & 1) == 1)
                    {
                        sum += arr[j];
                        stack.Push(j);

                    }
                }
                if (s == sum)
                {
                    check = true;
                    foreach (int num in stack)
                    {
                        Console.Write("{0} ", arr[num]);
                    }
                    Console.WriteLine();
                }
            }

            if (!check)
            {
                Console.WriteLine("There is no subset with this sum!");
            }
        }
    }
}

