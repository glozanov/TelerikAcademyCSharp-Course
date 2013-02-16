using System;


namespace _01.Integers_multiplied_by_five
{
    class Integer_Multiply_by_Five
    {
        static void Main()
        {
            int[] array = new int [20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 5 * array[i];
                Console.WriteLine(array[i] +"");
            }
        }
    }
}
