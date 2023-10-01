namespace _6.EqualSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool isFound = false;

            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (j < 0)
                    {
                        break;
                    }

                    leftSum += array[j];
                }

                for (int k = i + 1; k < array.Length; k++)
                {
                    if (k > array.Length - 1)
                    {
                        break;
                    }

                    rightSum += array[k];
                }

                if (leftSum == rightSum)
                {
                    isFound = true;
                    Console.Write(i);
                }

            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}