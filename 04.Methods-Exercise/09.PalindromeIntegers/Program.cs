using System.ComponentModel.Design;

namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                IsPalindromeNum(input);
            }
        }

        private static void IsPalindromeNum(string input)
        {
            string reversedInput = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedInput += input[i];
            }

            if (int.Parse(input) == int.Parse(reversedInput))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}