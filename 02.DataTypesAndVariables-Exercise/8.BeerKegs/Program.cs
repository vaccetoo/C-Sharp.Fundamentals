
int kegsCnt = int.Parse(Console.ReadLine());

double biggestKegVolume = double.MinValue;
string biggestKegModel = string.Empty;

for (int i = 0; i < kegsCnt; i++)
{
    string currKegegModel = Console.ReadLine();
    double currKegegRadius = double.Parse(Console.ReadLine());
    double currKegHeight = double.Parse(Console.ReadLine());

    // π * r^2 * h
    double currKegVolume = Math.PI * Math.Pow(currKegegRadius, 2) * currKegHeight;

    if (currKegVolume > biggestKegVolume)
    {
        biggestKegVolume = currKegVolume;
        biggestKegModel = currKegegModel;
    }
}

Console.WriteLine(biggestKegModel);