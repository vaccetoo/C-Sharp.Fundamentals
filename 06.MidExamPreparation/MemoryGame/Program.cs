using System.Globalization;
using System.Xml.Linq;

List<string> elements = Console.ReadLine()
    .Split()
    .ToList();

string command = string.Empty;

int movesCnt = 0;

int allMatchingElements = elements.Count / 2;
int foundMatchingElements = 0;

while ((command = Console.ReadLine()) != "end")
{
    List<int> index = command.Split()
        .Select(int.Parse)
        .ToList();

    if (index[0] > index[1])
    {
        index.Reverse();
    }

    movesCnt++;

    if (index[0] == index[1] || index[0] < 0 || index[0] > elements.Count - 1 || index[1] < 0 || index[1] > elements.Count - 1)
    {
        elements.Insert(elements.Count / 2, $"-{movesCnt}a");
        elements.Insert(elements.Count / 2, $"-{movesCnt}a");

        allMatchingElements++;

        Console.WriteLine("Invalid input! Adding additional elements to the board");
    }
    else if (elements[index[0]] == elements[index[1]])
    {
        Console.WriteLine($"Congrats! You have found matching elements - {elements[index[0]]}!");

        foundMatchingElements++;

        elements.RemoveAt(index[0]);
        elements.RemoveAt(index[1] - 1);

    }
    else if (elements[index[0]] != elements[index[1]])
    {
        Console.WriteLine("Try again!");
    }

    if (allMatchingElements == foundMatchingElements)
    {
        Console.WriteLine($"You have won in {movesCnt} turns!");
        break;
    }
}

if (foundMatchingElements < allMatchingElements)
{
    Console.WriteLine("Sorry you lose :(");
    Console.WriteLine(string.Join(" ", elements));
}
