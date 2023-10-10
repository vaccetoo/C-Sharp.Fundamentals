
int[] targets = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

string command = string.Empty;

int shotTargets = 0;

while ((command = Console.ReadLine()) != "End")
{
    int currTarget = int.Parse(command);

    if (currTarget >= targets.Length)
    {
        continue;
    }

    int currTargetValue = targets[currTarget];

    if (targets[currTarget] != -1)
    {
        targets[currTarget] = -1;
        shotTargets++;
    }

    for (int i = 0; i < targets.Length; i++)
    {
        if (targets[i] > currTargetValue && targets[i] != -1)
        {
            targets[i] -= currTargetValue;
        }
        else if (targets[i] <= currTargetValue && targets[i] != -1)
        {
            targets[i] += currTargetValue;
        }
    }
}

Console.WriteLine($"Shot targets: {shotTargets} -> {string.Join(" ", targets)}");