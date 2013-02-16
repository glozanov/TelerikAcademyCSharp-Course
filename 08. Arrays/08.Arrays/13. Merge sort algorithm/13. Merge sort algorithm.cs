using System;


namespace _13.Merge_sort_algorithm
{
    class Merge_sort_Algorithm
    {

        private static void m_sort(int[] a, int n, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                m_sort(a, n, left, mid);
                m_sort(a, n, mid + 1, right);

                merge(a, n, left, mid + 1, right);
            }
        }

        private static void merge(int[] a, int n, int left, int mid, int right)
        {
            int i, left_end, num_elements, tmp_pos;
            int[] b = new int[n];
            left_end = mid - 1;
            tmp_pos = left;
            num_elements = right - left + 1;

            while ((left <= left_end) && (mid <= right))
            {
                if (a[left] <= a[mid])
                {
                    b[tmp_pos] = a[left];
                    tmp_pos = tmp_pos + 1;
                    left = left + 1;
                }
                else
                {
                    b[tmp_pos] = a[mid];
                    tmp_pos = tmp_pos + 1;
                    mid = mid + 1;
                }
            }

            while (left <= left_end)
            {
                b[tmp_pos] = a[left];
                left = left + 1;
                tmp_pos = tmp_pos + 1;
            }

            while (mid <= right)
            {
                b[tmp_pos] = a[mid];
                mid = mid + 1;
                tmp_pos = tmp_pos + 1;
            }

            for (i = 0; i < num_elements; i++)
            {
                a[right] = b[right];
                right = right - 1;
            }
        }

        public static void Main()
        {
            Console.Write("Number of elements in the array:");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            Console.WriteLine();

            Console.WriteLine(" Enter array elements  ");



            for (int i = 0; i < n; i++)
            {
                Console.Write("<{0}> ", i + 1);
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }

            m_sort(a, n, 0, n - 1);

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
