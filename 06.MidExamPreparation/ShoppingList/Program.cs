
List<string> products = Console.ReadLine()
    .Split("!", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string command = string.Empty;

while ((command = Console.ReadLine()) != "Go Shopping!")
{
    List<string> currCommand = command
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToList();

    if (currCommand.First() == "Urgent")
    {
        AddItemAtTheStart(products, currCommand);
    }
    else if (currCommand.First() == "Unnecessary")
    {
        RemoveTheItem(products, currCommand);
    }
    else if (currCommand.First() == "Correct")
    {
        SwapTheItems(products, currCommand);
    }
    else if (currCommand.First() == "Rearrange")
    {
        PlaceTheItemAtTheEnd(products, currCommand);
    }
}

Console.WriteLine(string.Join(", ", products));

void PlaceTheItemAtTheEnd(List<string> products, List<string> currCommand)
{
    // Rearrange {item}" - if the grocery exists in the list, remove it from its current position and add it at the end of the list. Otherwise, skip this command.

    if (products.Contains(currCommand[1]))
    {
        products.Remove(currCommand[1]);
        products.Add(currCommand[1]);
    }
}

void SwapTheItems(List<string> products, List<string> currCommand)
{
    // "Correct {oldItem} {newItem}" - if the item with the given old name exists, change its name with the new one. Otherwise, skip this command

    if (products.Contains(currCommand[1]))
    {
        int index = products.IndexOf(currCommand[1]);
        products.RemoveAt(index);
        products.Insert(index, currCommand[2]);
    }
}

void RemoveTheItem(List<string> products, List<string> currCommand)
{
    // "Unnecessary {item}" - remove the item with the given name, only if it exists in the list. Otherwise, skip this command.

    if (products.Contains(currCommand[1]))
    {
        products.Remove(currCommand[1]); 
    }
}

void AddItemAtTheStart(List<string> products, List<string> currCommand)
{
    // "Urgent {item}" - add the item at the start of the list.  If the item already exists, skip this command.

    if (!products.Contains(currCommand[1]))
    {
        products.Insert(0, currCommand[1]);
    }
}