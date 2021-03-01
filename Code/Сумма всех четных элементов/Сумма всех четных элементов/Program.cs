using System;

namespace Сумма_всех_четных_элементов
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 56, 90, 21, 32, 53, 78, 98, 10, 35, 4 };
            int result = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    result += myArray[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
