
using System.Xml.Serialization;

List<int> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

double numbersAvergeValue = numbers.Sum() / numbers.Count;

List<int> numbersGreaterThanTheAvergeValue = new List<int>();

for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] > numbersAvergeValue)
    {
        if (numbersGreaterThanTheAvergeValue.Count < 5)
        {
            numbersGreaterThanTheAvergeValue.Add(numbers[i]);
        }
    }
}

if (numbersGreaterThanTheAvergeValue.Count > 0)
{
    numbersGreaterThanTheAvergeValue.Sort();
    numbersGreaterThanTheAvergeValue.Reverse();

    Console.WriteLine(string.Join(" ", numbersGreaterThanTheAvergeValue));
}
else
{
    Console.WriteLine("No");
}

