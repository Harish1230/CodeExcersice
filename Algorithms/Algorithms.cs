using System;
using System.Linq;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int n){
            if (n < 0)
            {
                throw new ArgumentException("Input should be a non-negative integer.");
            }
            return (n == 0 || n == 1) ? 1 : n * GetFactorial(n - 1);
        }

        public static string FormatSeparators(params string[] items) 
	{
            if (items == null || items.Length == 0)
            {
                throw new ArgumentException("At least one item should be provided.");
            }
            if (items.Length == 1)
            {
                return items[0];
            }
            if (items.Length == 2)
            {
                return $"{items[0]} and {items[1]}";
            }
            return $"{string.Join(", ", items.Take(items.Length - 1))}, and {items.Last()}";
        }
    }
}
