namespace _2.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintVowelsCnt(input);
        }

        private static void PrintVowelsCnt(string input)
        {
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'A' || input[i] == 'o' || input[i] == 'O' || input[i] == 'u' || input[i] == 'U' || input[i] == 'e' || input[i] == 'E' || input[i] == 'i' || input[i] == 'I' || input[i] == 'y' || input[i] == 'Y')
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}