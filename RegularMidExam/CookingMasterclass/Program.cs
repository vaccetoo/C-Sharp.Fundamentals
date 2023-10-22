double budget = double.Parse(Console.ReadLine());
int studentsCnt = int.Parse(Console.ReadLine());
double flourPrice = double.Parse(Console.ReadLine());
double eggPrice = double.Parse(Console.ReadLine());
double apronPrice = double.Parse(Console.ReadLine());

int freePackages = 0;

for (int i = 1; i <= studentsCnt; i++)
{
    if (i % 5 == 0)
    {
        freePackages++;
    }
}

double finalFlourPrice = (studentsCnt - freePackages) * flourPrice;

double finalEggsPrice = studentsCnt * 10 * eggPrice;

double addAprons = Math.Ceiling(0.2 * studentsCnt);
double finalApronPrice = (studentsCnt + addAprons) * apronPrice;

double totalPrice = finalFlourPrice + finalEggsPrice + finalApronPrice;

if (totalPrice <= budget)
{
    Console.WriteLine($"Items purchased for {totalPrice:f2}$.");
}
else
{
    Console.WriteLine($"{(totalPrice - budget):f2}$ more needed.");
}