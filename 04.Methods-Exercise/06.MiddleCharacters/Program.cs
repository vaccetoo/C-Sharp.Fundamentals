namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddleChar(input);
        }

        private static void PrintMiddleChar(string input)
        {
            char middleChar;
            char middleChar2;

            if (input.Length % 2 == 0)
            {
                middleChar = input[input.Length / 2];
                middleChar2 = input[input.Length / 2 - 1];
                Console.WriteLine($"{middleChar2}{middleChar}");
            }
            else
            {
                middleChar = input[input.Length / 2];
                Console.WriteLine(middleChar);
            }
        }
    }
}

