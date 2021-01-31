using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.Domain
{
    public static class MethodCollection
    {
        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        public static int WordCount(string sentence)
        {
            char[] separatorCharacters = new char[3] { ' ', '.', ';' };
            string[] words = sentence.Split(separatorCharacters);
            return words.Length;
        }

        public static bool IsPrimeNumber(int number)
        {
            bool isPrimeNumber = true;

            if (number > 1)
                for (int i = 2; i < number; i++)
                    if (number % i == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }

            return isPrimeNumber;

        }
    }
}
