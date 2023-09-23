
int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

static void DecreaseIndexes(int[] numbers)
{
    // decrease all ellements in the array with 1 ---> numbers[]

    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = numbers[i] - 1;
    }
}

static void MultiplyIndexes(int[] numbers, string[] currCommand)
{
    // multiply {index1} {index2} ---> numbers[]

    int index1 = int.Parse(currCommand[1]);
    int index2 = int.Parse(currCommand[2]);

    numbers[index1] = numbers[index2] * numbers[index1];
}

static void SwapIndexes(int[] numbers, string[] currCommand)
{
    // swap {index1} {index2} ---> numbers[]

    int index1 = int.Parse(currCommand[1]);
    int index2 = int.Parse(currCommand[2]);

    int currIndex = numbers[index1];
    numbers[index1] = numbers[index2];
    numbers[index2] = currIndex;
}

string command = string.Empty;

while ((command = Console.ReadLine()) != "end") 
{
    string[] currCommand = command.Split();

    if (currCommand.First() == "swap")
    {
        SwapIndexes(numbers, currCommand);
    }
    else if (currCommand.First() == "multiply")
    {
        MultiplyIndexes(numbers, currCommand);
    }
    else if (currCommand.First() == "decrease")
    {
        DecreaseIndexes(numbers);
    }
}

Console.WriteLine(string.Join(", ", numbers));