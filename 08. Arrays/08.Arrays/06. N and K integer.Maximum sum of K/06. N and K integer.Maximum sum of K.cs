using System;
using System.Text;

namespace _06.N_and_K_integer.Maximum_sum_of_K
{
    class N_and_K_Integer_Maximum_sum_of_K
    {
        static void Main()
        {
            uint k = uint.Parse(Console.ReadLine());
            uint n = uint.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (uint i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            Array.Sort(array);
            int sum = 0;
            StringBuilder longestNumber = new StringBuilder("");
            for (uint i = n - k; i < n; i++)
            {
                sum += array[i];
                if (i == n - k) longestNumber.Append(array[i]);
                else longestNumber.Append("," + array[i]);
            }
            Console.WriteLine(sum);
            Console.Write("{" + longestNumber + "}");

        }
    }
}