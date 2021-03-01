
using System;
namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = { '1', '2', '3', '2', '1' };
            if (IsPalindrom(arr))
                Console.WriteLine("Является палиндромом");
            else
                Console.WriteLine("Не является палиндромом");
        }

        static bool IsPalindrom(char[] word)
        {
            for (int i = 0; i < word.Length / 2; i++)
                if (word[i] != word[word.Length - 1 - i])
                    return false;
            return true;
        }
    }
}