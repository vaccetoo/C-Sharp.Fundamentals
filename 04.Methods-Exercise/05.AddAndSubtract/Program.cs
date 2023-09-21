namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = ReturnSumOfFirstTwo(numbers);

            int result = SubtracktThirdFromSum(numbers, sum);

            Console.WriteLine(result);
        }

        private static int SubtracktThirdFromSum(int[] numbers, int sum)
        {
            int result = sum - numbers[2];
            return result;
        }

        private static int ReturnSumOfFirstTwo(int[] numbers)
        {
            int sum = numbers[0] + numbers[1];
            return sum;
        }
    }
}
