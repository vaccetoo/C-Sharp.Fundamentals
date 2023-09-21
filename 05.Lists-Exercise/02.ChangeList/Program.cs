namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                List<string> input = command.Split().ToList();

                if (input.First() == "Delete")
                {
                    list.RemoveAll(x => x == int.Parse(input.Last()));
                }
                else if (input.First() == "Insert")
                {
                    list.Insert(int.Parse(input[2]), int.Parse(input[1]));
                }
            }

            if (command == "end")
            {
                Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}