
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

    int ladyBugIndex = int.Parse(currCommand[0]);
    string direction = currCommand[1];
    int flyLength = int.Parse(currCommand[2]);

    if (ladyBugIndex < 0 || ladyBugIndex >= field.Length)
    {
        continue;
    }

    if (direction == "right")
    {
        int startIndex = ladyBugIndex;
        int endIndex = startIndex + flyLength;
    }
    else if (direction == "left")
    {
        int startIndex = ladyBugIndex;
        int endIndex = startIndex - flyLength;
    }
}

Console.WriteLine(string.Join(" ", field));
