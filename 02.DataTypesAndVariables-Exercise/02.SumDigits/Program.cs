namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            FindSumOfDigits(number);
        }

        private static void FindSumOfDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int currDigit = number % 10;
                sum += currDigit;
                number /= 10; // take next number
            }

            Console.WriteLine(sum);
        }
    }
}
