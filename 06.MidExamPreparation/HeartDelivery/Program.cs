
List<int> houses = Console.ReadLine()
    .Split("@", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

string command = string.Empty;

while ((command = Console.ReadLine()) != "Love!")
{
    List<string> jumpCommand = command.Split(" ").ToList();
    
    int jumpLength = int.Parse(jumpCommand[1]);
}

Console.WriteLine(string.Join(" ", houses));
