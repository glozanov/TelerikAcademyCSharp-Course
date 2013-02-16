using System;


namespace _05.Maximum_increasing_seqence
{
    class Maximum_Increasing_Sequence
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (uint i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            int searchedItem = array[0];
            int currentSequence = 1;
            int longestSequence = 1;
            string number = Convert.ToString(array[0]);
            string longestNumber = "";
            for (int i = 1; i < n; i++)
            {
                if (array[i] > searchedItem)
                {
                    currentSequence++;
                    searchedItem = array[i];
                    number += "," + Convert.ToString(array[i]);
                    if (i == n - 1 && longestSequence < currentSequence)
                    {
                        longestSequence = currentSequence;
                        longestNumber = number;
                    }

                }
                else
                {
                    if (longestSequence <= currentSequence)
                    {

                        longestSequence = currentSequence;
                        longestNumber = number;
                    }
                    currentSequence = 1;
                    searchedItem = array[i];

                    number = Convert.ToString(array[i]);
                    // longestNumber = number;

                }
            }
            // Console.WriteLine(longestSequence);

            Console.Write("{" + longestNumber + "}");

        }
    }
}
