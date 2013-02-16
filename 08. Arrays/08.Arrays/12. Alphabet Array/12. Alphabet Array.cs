using System;


namespace _12.Alphabet_Array
{
    class Alphabet_Array
    {
        static void Main()
        {
            char[] letters = new char[26]; //{ 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 97; i < 123; i++)
            {
                letters[i - 97] = Convert.ToChar(i);
            }
            string word = Console.ReadLine();
            word = word.ToLower();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (word[i] == letters[j])
                    {
                        Console.Write(j + " ");
                        break;
                    }
                }
            }
        }
    }
}

