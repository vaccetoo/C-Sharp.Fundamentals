
using System.Diagnostics;

int ordersCnt = int.Parse(Console.ReadLine());

double pricePerCapsule = 0;
double daysCnt = 0;
int capsuleCnt = 0;

double totalPrice = 0;

for (int i = 1; i <= ordersCnt; i++)
{
    pricePerCapsule = double.Parse(Console.ReadLine());
    daysCnt = double.Parse(Console.ReadLine());
    capsuleCnt = int.Parse(Console.ReadLine());

    double currentPrice = (daysCnt * capsuleCnt) * pricePerCapsule;

    Console.WriteLine($"The price for the coffee is: ${currentPrice:f2}");

    totalPrice += currentPrice;
}

Console.WriteLine($"Total: ${totalPrice:f2}");