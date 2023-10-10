
int fieldSize = int.Parse(Console.ReadLine());

int[] field = new int[fieldSize];

int[] indexesWithLadyBug = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

for (int i = 0; i < field.Length; i++)
{
    if (indexesWithLadyBug.Contains(i))
    {
        field[i] = 1;
    }
    else
    {
        field[i] = 0;
    }
}

string command = string.Empty;

while ((command = Console.ReadLine()) != "end")
{
    string[] currCommand = command.Split();

    int ladyBugCurrIndex = int.Parse(currCommand[0]);
    string direction = currCommand[1];
    int flyLength = int.Parse(currCommand[2]);

    if (ladyBugCurrIndex < 0 || ladyBugCurrIndex >= field.Length || field[ladyBugCurrIndex] == 0)
    {
        continue;
    }

    field[ladyBugCurrIndex] = 0;

    if (direction == "right")
    {
        int endIndex = ladyBugCurrIndex + flyLength;

        while (endIndex >= 0 && endIndex < field.Length && field[endIndex] != 0)
        {
            endIndex += flyLength;
        }

        if (endIndex >= 0 && endIndex < field.Length)
        {
            field[endIndex] = 1;
        }
    }
    else if (direction == "left")
    {
        int endIndex = ladyBugCurrIndex - flyLength;

        while (endIndex >= 0 && endIndex < field.Length && field[endIndex] != 0)
        {
            endIndex -= flyLength;
        }

        if (endIndex >= 0 && endIndex < field.Length)
        {
            field[endIndex] = 1;
        }
    }
}

Console.WriteLine(string.Join(" ", field));