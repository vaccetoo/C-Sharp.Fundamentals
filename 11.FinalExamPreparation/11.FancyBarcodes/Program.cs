
using System.Text.RegularExpressions;

int barcodesCount = int.Parse(Console.ReadLine());

for (int i = 0; i < barcodesCount; i++)
{
    string currentBarcode = Console.ReadLine();

    Regex checkBarcode = new Regex(@"@#{1,}(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])@#{1,}");

    Match match = checkBarcode.Match(currentBarcode);

    if (match.Success)
    {
        string barcode = match.Groups["barcode"].Value;

        string group = string.Empty;

        int digitsCount = 0;

        for (int j = 0; j < barcode.Length; j++)
        {
            if (char.IsDigit(barcode[j]))
            {
                digitsCount++;
                group += barcode[j];
            }
        }

        if (digitsCount == 0)
        {
            group = "00";
        }

        Console.WriteLine($"Product group: {group}");
    }
    else
    {
        Console.WriteLine("Invalid barcode");
    }
}