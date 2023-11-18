
string[] input = Console.ReadLine()
    .Split();

string firstString = input[0];
string secondString = input[1];

int sum = GetCharactersSum(firstString, secondString);

Console.WriteLine(sum);

static int GetCharactersSum(string firstString, string secondString)
{
    int sum = 0;

    int maxLength = Math.Max(firstString.Length, secondString.Length);

    for (int i = 0; i < maxLength; i++)
    {
        int characterValue1 = i < firstString.Length ? firstString[i] : 1;
        int characterValue2 = i < secondString.Length ? secondString[i] : 1;

        sum += characterValue1 * characterValue2;
    }

    return sum;
}