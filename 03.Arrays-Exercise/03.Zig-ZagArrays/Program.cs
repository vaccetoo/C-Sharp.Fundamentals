using System.ComponentModel.Design;

namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraysCnt = int.Parse(Console.ReadLine());

            int[] oddArray = new int[arraysCnt];
            int[] evenArray = new int[arraysCnt];

            for (int i = 0; i < arraysCnt; i++)
            {
                int[] currentArray = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 != 0)
                {
                    oddArray[i] = currentArray[0];
                    evenArray[i] = currentArray[1];
                }
                else
                {
                    oddArray[i] = currentArray[1];
                    evenArray[i] = currentArray[0];
                }
            }

            Console.WriteLine(string.Join(" ", evenArray));
            Console.WriteLine(string.Join(" ", oddArray));
        }
    }
}
