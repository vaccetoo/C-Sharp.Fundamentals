namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= endNumber; i++)
            {
                if (IsDivisibileByEight(i) && HasAtLeastOneOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool HasAtLeastOneOddDigit(int number)
        {
            bool isFound = false;

            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;

                if (digit % 2 != 0)
                {
                    isFound = true;
                    break;
                }
            }

            return isFound;
        }

        private static bool IsDivisibileByEight(int number)
        {
            int sumOfDigits = 0;

            while (number > 0)
            {
                int digit = number % 10;
                sumOfDigits += digit;
                number /= 10;
            }

            return sumOfDigits % 8 == 0;
        }
    }
}