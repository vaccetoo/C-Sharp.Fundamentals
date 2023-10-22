﻿List<int> items = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

int entryPoint = int.Parse(Console.ReadLine());

string command = Console.ReadLine();

int entryItemValue = items[entryPoint];

int leftDmg = 0;
int rightDmg = 0;

string position = string.Empty;

if (command == "cheap")
{
    for (int i = entryPoint - 1; i >= 0; i--)
    {
        if (items[i] < entryItemValue)
        {
            leftDmg += items[i];
        }
    }

    for (int i = entryPoint + 1; i < items.Count; i++)
    {
        if (items[i] < entryItemValue)
        {
            rightDmg += items[i];
        }
    }
}
else if (command == "expensive")
{
    for (int i = entryPoint - 1; i >= 0; i--)
    {
        if (items[i] >= entryItemValue)
        {
            leftDmg += items[i];
        }
    }

    for (int i = entryPoint + 1; i < items.Count; i++)
    {
        if (items[i] >= entryItemValue)
        {
            rightDmg += items[i];
        }
    }
}

if (rightDmg > leftDmg)
{
    position = "Right";

    Console.WriteLine($"{position} - {rightDmg}");
}
else
{
    position = "Left";

    Console.WriteLine($"{position} - {leftDmg}");
}