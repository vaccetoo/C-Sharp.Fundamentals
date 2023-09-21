namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> specialNumPower = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int bomb = specialNumPower[0];
            int power = specialNumPower[1];

            while (numbers.Contains(bomb))
            {
                int bombIndex = numbers.IndexOf(bomb);

                int start = bombIndex - power;
                int end = bombIndex + power;
                int count = end - start + 1;

                if (start >= 0 && count <= numbers.Count - 1)
                {
                    numbers.RemoveRange(start, count);
                }
                else if (start < 0 && count > numbers.Count - 1)
                {
                    start = 0;
                    count = (numbers.Count - 1) - start + 1;
                    numbers.RemoveRange(start, count);
                }
                else if (start < 0 || count > numbers.Count - 1)
                {
                    if (start < 0)
                    {
                        start = 0;
                        numbers.RemoveRange(start, count);
                    }
                    else if ((end - start + 1) > numbers.Count - 1)
                    {
                        count = (numbers.Count - 1) - start + 1;
                        numbers.RemoveRange(start, count);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers.Sum()));
        }
    }
}

