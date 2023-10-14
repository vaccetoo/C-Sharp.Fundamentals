
List<string> chest = Console.ReadLine()
    .Split("|", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string command = string.Empty;

while ((command = Console.ReadLine()) != "Yohoho!")
{
    List<string> currCommand = command.Split().ToList();

    if (currCommand.First() == "Loot")
    {
        chest = InsertItemAtTheBegining(chest, currCommand);
    }
    else if (currCommand.First() == "Drop")
    {
        int currIndex = int.Parse(currCommand[1]);

        chest = AddItemAtTheEnd(chest, currIndex);
    }
    else if (currCommand.First() == "Steal")
    {
        int count = int.Parse(currCommand[1]);

        chest = RemoveItems(chest, count);
    }
}

List<string> RemoveItems(List<string> chest, int count)
{
    throw new NotImplementedException();
}

List<string> AddItemAtTheEnd(List<string> chest, int currIndex)
{
    throw new NotImplementedException();
}

List<string> InsertItemAtTheBegining(List<string> chest, List<string> currCommand)
{
    throw new NotImplementedException();
}