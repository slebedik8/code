using System;

namespace Сумма_максимального_и_минимального_значения
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 56, 90, 21, 32, 53, 78, 98, 10, 35, 4 };
            int minValue = myArray[0];
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < minValue)

                {
                    minValue = myArray[i];
                }
            }
            int maxValue = myArray[0];
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] > maxValue)
                {
                    maxValue = myArray[i];
                }
            }
            Console.WriteLine(maxValue - minValue);
        }
    }
}