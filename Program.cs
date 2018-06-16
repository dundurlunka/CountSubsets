namespace CountSubsets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the array of numbers on one row, each number divided by a space: ");
            long[] inputArray = GetInputArray();

            Console.WriteLine($"Total combinations: {TotalCombinations(inputArray.Length)}");
        }

        private static long[] GetInputArray()
        {
            return Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .Distinct()
                .Where(n => n % 2 == 0 && n != 0)
                .ToArray();
        }

        public static long Factorial(long num)
        {
            if (num <= 1)
            {
                return 1;
            }
            return num * Factorial(num - 1);
        }

        public static long Combination(long numberOfElements, long numberOfPlaces)
        {
            return Factorial(numberOfElements) / (Factorial(numberOfPlaces) * Factorial(numberOfElements - numberOfPlaces));
        }

        public static long TotalCombinations(long numberOfElementsInArray)
        {
            long totalAmount = 0;

            for (long i = 1; i <= numberOfElementsInArray; i++)
            {
                totalAmount += Combination(numberOfElementsInArray, i);
            }
            return totalAmount;
        }
    }
}
