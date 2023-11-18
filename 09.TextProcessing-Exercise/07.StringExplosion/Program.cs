
using System.Text;

string input = Console.ReadLine();

StringBuilder output = new StringBuilder();

int explosionLength = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '>')
    {
        explosionLength += int.Parse(input[i + 1].ToString());

        output.Append(input[i]);
    }
    else if (explosionLength > 0)
    {
        explosionLength--;
    }
    else
    {
        output.Append(input[i]);
    }

}

Console.WriteLine(output);