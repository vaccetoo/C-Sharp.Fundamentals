
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
    else if (currCommand.First() == "Combine")
    {
        string oldItem = currCommand[2];
        string newItem = currCommand[3];

        if (journal.Contains(oldItem))
        {
            int index = journal.IndexOf(oldItem);
            journal.Insert(index + 1, newItem);
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