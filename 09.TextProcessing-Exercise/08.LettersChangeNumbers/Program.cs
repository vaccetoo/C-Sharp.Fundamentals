
using System.Text;

string[] input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

double result = 0;

foreach (string text in input)
{
    double currentNnumber = double.Parse(text.Substring(1, text.Length - 2));

    if (char.IsUpper(text[0]))
    {
        int divider = text[0] % 32;

        currentNnumber /= divider;
    }
    else if (char.IsLower(text[0]))
    {
        int multiplier = text[0] % 32;

        currentNnumber *= multiplier;
    }

    if (char.IsUpper(text[text.Length - 1]))
    {
        int subtractNumber = text[text.Length - 1] % 32;

        currentNnumber -= subtractNumber;
    }
    else if (char.IsLower(text[text.Length - 1]))
    {
        int addNumber = text[text.Length - 1] % 32;

        currentNnumber += addNumber;
    }

    result += currentNnumber;
}

Console.WriteLine($"{result:f2}");