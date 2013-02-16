using System;
using System.Text;
namespace _08.Maximum_sum_of_given_integer
{
    class Maximum_sum_of_given_integer
    {
        static void Main()
        {

            //  int n = int.Parse(Console.ReadLine());  //remove to enter array

            int[] array = new int[10] { 2, 3, -6,-1, 2,-1, 6, 4, -8, 8 }; //remove to enter array
            Console.WriteLine(" 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 }");
            //for (int i = 0; i < n; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());   //remove to enter array
            //}
            int sequence = 1;
            int maxSum = 0;
            StringBuilder currentSequence = new StringBuilder();
            StringBuilder maxSequence = new StringBuilder();
            while (true)
            {

                for (int i = 0; i < 10; i++)  //instead 10   n 
                {

                    int sum = 0;
                    int end;
                    currentSequence.Clear();

                    if (i + sequence <= 10)
                    {
                        end = i + sequence;
                    }
                    else
                    {
                        break;
                    }
                    for (int start = i; start < end; start++)
                    {
                        sum += array[start];
                        currentSequence.Append(array[start] + " ");


                    }

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        maxSequence.Clear();
                        maxSequence.Append(currentSequence);
                    }




                }


                sequence++;
                if (sequence == 11) break;  //instead 11    ---  n-1

            }
            Console.WriteLine(maxSum);
            Console.WriteLine("{" + maxSequence + "}");
        }
    }
}
