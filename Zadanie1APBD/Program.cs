using System;

namespace Zadanie1APBD
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //zmiany
            int[] numbers = { 1, 2, 3, 4, 5 };
            double average = CalculateAverage(numbers);
            Console.WriteLine($"Średnia: {average}");

            int max = FindMaxValue(numbers);
            Console.WriteLine($"Maksymalna wartość: {max}");
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
        
        public static int FindMaxValue(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Tablica nie może być pusta");
            }

            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            return max;
        }
    }
}