
List<string> journal = Console.ReadLine()
    .Split(", ")
    .ToList();

string command = string.Empty;

while ((command = Console.ReadLine()) != "Craft!")
{
    string[] currCommand = command.Split(" - ");

    string item = currCommand[1];

    if (currCommand.First() == "Collect")
    {
        if (!journal.Contains(item))
        {
            journal = AddItem(journal, item);
        }
    }
    else if (currCommand.First() == "Drop")
    {
        if (journal.Contains(item))
        {
            journal.Remove(item);
        }
    }
    else if (currCommand.First() == "Combine Items")
    {
        string[] items = currCommand[1].Split(":");

        if (journal.Contains(items[0]))
        {
            int index = journal.IndexOf(items[0]);
            journal.Insert(index + 1, items[1]);
        }
    }
    else if (currCommand.First() == "Renew")
    {
        if (journal.Contains(item))
        {
            journal.Remove(item);
            journal.Add(item);
        }
    }
}

if (command == "Craft!")
{
    Console.WriteLine(string.Join(", ", journal));
}

List<string> AddItem(List<string> journal, string item)
{
    journal.Add(item);

    return journal;
}
