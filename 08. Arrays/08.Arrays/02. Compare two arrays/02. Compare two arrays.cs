using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Compare_two_arrays
{
    class Comparwe_Two_Arrays
    {
        static void Main()
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            int[] array2 = new int[n];
            Console.WriteLine("Array 1 :");
            for (int i = 0; i < n; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array 2 :");
            for (int i = 0; i < n; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }
            bool equal = false;
            for (int i = 0; i < n; i++)
            {
                if (array1[i] == array2[i])
                {
                    equal = true;
                }

                else
                {
                    equal = false;
                    break;
                }
                
            }
            Console.WriteLine(equal);
        }   
        
    }
}
