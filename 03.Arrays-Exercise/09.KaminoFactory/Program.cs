int dnaLength = int.Parse(Console.ReadLine());

string command = string.Empty;

int[] currDnaArray = new int[dnaLength];
int[] longestDnaArray = new int[dnaLength];

int currSequence = 0;
int longestSequence = 0;

int currStartIndex = 0;
int leftmostStartIndex = int.MaxValue;

int currSum = 0;
int biggestSum = 0;

int arrayCnt = 0;
int bestArray = 0;

while ((command = Console.ReadLine()) != "Clone them!")
{
    currDnaArray = command
        .Split("!", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    arrayCnt++;
    currSum = currDnaArray.Sum();

    for (int i = 0; i < currDnaArray.Length - 1; i++)
    {
        currSequence = 0;

        for (int j = i + 1; j < currDnaArray.Length; j++)
        {
            if (currDnaArray[i] == 1 && currDnaArray[j] == 1)
            {
                currSequence++;
                currStartIndex = i;
            }
            else
            {
                break;
            }
        }

        if ((currSequence > longestSequence) || (currSequence == longestSequence && currStartIndex < leftmostStartIndex) || (currSequence == longestSequence && currStartIndex == leftmostStartIndex && currSum > biggestSum))
        {
            longestDnaArray = currDnaArray;
            longestSequence = currSequence;
            leftmostStartIndex = currStartIndex;
            biggestSum = currSum;
            bestArray = arrayCnt;
        }
    }
}

Console.WriteLine($"Best DNA sample {bestArray} with sum: {biggestSum}.");
Console.WriteLine(string.Join(" ", longestDnaArray));