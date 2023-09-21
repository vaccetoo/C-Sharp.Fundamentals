namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandCnt = int.Parse(Console.ReadLine());

            List<string> guestList = new List<string>();

            for (int i = 0; i < commandCnt; i++)
            {
                string command = Console.ReadLine();

                List<string> commandParts = command.Split().ToList();

                if (commandParts.Count == 3)
                {
                    string name = commandParts[0];

                    if (guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(name);
                    }
                }
                else if (commandParts.Count == 4)
                {
                    string name = commandParts[0];

                    if (guestList.Contains(name))
                    {
                        guestList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            foreach (string guest in guestList)
            {
                Console.WriteLine(guest);
            }
        }
    }
}

