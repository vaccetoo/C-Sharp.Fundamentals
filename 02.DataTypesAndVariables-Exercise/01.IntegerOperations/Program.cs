namespace _01.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[4];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Add first to the second number
            int firstOperation = AddNumbers(numbers[0], numbers[1]);

            // Divide (integer) the result of the first operation by the third number
            int secondOperation = DivideNumbers(firstOperation, numbers[2]);

            // Multiply the result of the second operation by the fourth number
            int thirdOperation = MultiplyTwoNumbers(secondOperation, numbers[3]);

            int result = thirdOperation;

            Console.WriteLine(result);
        }

        private static int MultiplyTwoNumbers(int number1, int number2)
        {
            int result = number1 * number2;
            return result;
        }

        private static int DivideNumbers(int number1, int number2)
        {
            int result = number1 / number2;
            return result;
        }

        private static int AddNumbers(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }
    }
}
