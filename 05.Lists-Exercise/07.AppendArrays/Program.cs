namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToList();

            List<string> result = new List<string>();

            foreach (string item in input)
            {
                result.AddRange(item.Split(" ", StringSplitOptions.RemoveEmptyEntries));
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}