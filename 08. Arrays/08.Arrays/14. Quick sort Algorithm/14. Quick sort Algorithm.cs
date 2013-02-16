using System;

namespace _14.Quick_sort_Algorithm
{
    class Quick_sort_Algorithm
    {

        private static void QuickSort(string[] a, int left, int right)
        {
            int i = left;
            int j = right;
            string leftString = a[i];
            string rightString = a[j];
            double pivotValue = ((left + right) / 2);
            string middle = a[Convert.ToInt32(pivotValue)];
            string temp = null;
            while (i <= j)
            {
                while (a[i].CompareTo(middle) < 0)
                {
                    i++;
                    leftString = a[i];
                }
                while (a[j].CompareTo(middle) > 0)
                {
                    j--;
                    rightString = a[j];
                }
                if (i <= j)
                {
                    temp = a[i];
                    a[i++] = a[j];
                    a[j--] = temp;
                }
            }
            if (left < j)
            {
                QuickSort(a, left, j);
            }
            if (i < right)
            {
                QuickSort(a, i, right);
            }
        }

        public static void Main()
        {
            Console.Write("Number of elements in the array:");
            int n = int.Parse(Console.ReadLine());
            string[] a = new string[n];

            Console.WriteLine();

            Console.WriteLine(" Enter array elements  ");

            for (int i = 0; i < n; i++)
            {
                Console.Write("<{0}> ", i + 1);
                string s1 = Console.ReadLine();
                a[i] = s1;
            }

            QuickSort(a, 0, n - 1);

            Console.WriteLine();

            Console.WriteLine(" Sorted array elements ");

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }

            Console.ReadLine();
        }
    }
}
