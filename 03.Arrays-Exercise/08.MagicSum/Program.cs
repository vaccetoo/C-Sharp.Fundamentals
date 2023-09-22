namespace _08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int magicNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == magicNum)
                    {
                        Console.Write($"{array[i]} {array[j]}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}