namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char input1 = char.Parse(Console.ReadLine());
            char input2 = char.Parse(Console.ReadLine());

            PrintCharsInRange(input1, input2);
        }

        private static void PrintCharsInRange(char input1, char input2)
        {
            char firstChar = input1;

            if (input1 > input2)
            {
                input1 = input2;
                input2 = firstChar;
            }

            for (char i = input1; i < input2; i++)
            {
                if (i > input1 && i < input2)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
