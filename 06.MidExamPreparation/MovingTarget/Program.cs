
List<int> targets = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

string inputCommand = string.Empty;

while ((inputCommand = Console.ReadLine()) != "End")
{
    string[] command = inputCommand.Split(" ");

    string currCommand = command[0];
    int currTarget = int.Parse(command[1]);
    int value = int.Parse(command[2]);

    if (currCommand == "Shoot")
    {
        targets = ShootTheTarget(targets, currTarget, value);
    }
    else if (currCommand == "Add")
    {
        targets = InsertTarget(targets, currTarget, value);
    }
    else if (currCommand == "Strike")
    {
        targets = RemoveTargetsInRadius(targets, currTarget, value);
    }
}

Console.WriteLine(string.Join("|", targets));

List<int> RemoveTargetsInRadius(List<int> targets, int currTarget, int radius)
{
    int startIndex = currTarget - radius;
    int endIndex = currTarget + radius;
    int length = endIndex - startIndex + 1;

    if (startIndex >= 0 && endIndex < targets.Count)
    {
        targets.RemoveRange(startIndex, length);

        return targets;
    }

    Console.WriteLine("Strike missed!");

    return targets;
}

List<int> InsertTarget(List<int> targets, int currTarget, int value)
{
    if (currTarget >= 0 && currTarget < targets.Count)
    {
        targets.Insert(currTarget, value);

        return targets;
    }

    Console.WriteLine("Invalid placement!");

    return targets;
}

List<int> ShootTheTarget(List<int> targets, int currTarget, int value)
{
    if (currTarget >= 0 && currTarget < targets.Count)
    {
        targets[currTarget] -= value;

        if (targets[currTarget] <= 0)
        {
            targets.RemoveAt(currTarget);

            return targets;
        }
    }

    return targets;
}