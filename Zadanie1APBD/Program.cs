using System;

namespace Zadanie1APBD
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //zmiany
            int[] numbers1 = { 1, 2, 3, 4, 5 };
            double average = CalculateAverage(numbers1);

            Console.WriteLine($"Średnia: {average}");
        }

        public static double CalculateAverage(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Tablica nie może być pusta");
            }

            double sum1 = 0;
            foreach (var num in numbers)
            {
                sum1 += num;
            }
            return sum1 / numbers.Length;
        }
    }
}