
using System.Security.Cryptography.X509Certificates;
using System.Text;

string input = Console.ReadLine();

StringBuilder result = new StringBuilder();

for (int i = 0; i < input.Length - 1; i++)
{
    if (input[i] != input[i + 1])
    {
        result.Append(input[i]);
    }
    else
    {
        continue;
    }
}

result.Append(input[input.Length - 1]);

Console.WriteLine(result);
