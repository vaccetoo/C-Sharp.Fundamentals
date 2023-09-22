namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rotationsCnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotationsCnt; i++)
            {
                int firstNum = array[0];

                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }

                array[array.Length - 1] = firstNum;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}

