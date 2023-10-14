
int days = int.Parse(Console.ReadLine());
int dailyPlunder =  int.Parse(Console.ReadLine());
double expectedPlunder = double.Parse(Console.ReadLine());

double totalPlunder = 0;
double addPlunder = 0;
double lostPlunder = 0;

for (int i = 1; i <= days; i++)
{
    totalPlunder += dailyPlunder;

    if (i % 3 == 0)
    {
        addPlunder += 0.5 * dailyPlunder;
        totalPlunder += 0.5 * dailyPlunder;
    }

    if (i % 5 == 0)
    {
        lostPlunder = 0.3 * totalPlunder;
        totalPlunder -= lostPlunder;
    }
}

double percentPlunder = (totalPlunder / expectedPlunder) * 100;

if (totalPlunder >= expectedPlunder)
{
    Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
}
else
{
    Console.WriteLine($"Collected only {percentPlunder:f2}% of the plunder.");
}