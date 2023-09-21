namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            double firstNumFactorial = CalculateFactorial(firstNum);
            double secondNumFactorial = CalculateFactorial(secondNum);

            double result = firstNumFactorial / secondNumFactorial;

            Console.WriteLine($"{result:f2}");
        }

        private static double CalculateFactorial(int firstNum)
        {
            double factorial = 1;

            for (int i = 1; i <= firstNum; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}

