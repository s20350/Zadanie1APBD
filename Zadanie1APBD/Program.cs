using System;

namespace Zadanie1APBD
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //zmiany
            int[] numbers45 = { 1, 2, 3, 4, 5 };
            double average = CalculateAverage(numbers45);
            Console.WriteLine($"Średnia: {average}");
        }

        public static double CalculateAverage(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Tablica nie może być pusta");
            }

            double sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum / numbers.Length;
        }
    }
}