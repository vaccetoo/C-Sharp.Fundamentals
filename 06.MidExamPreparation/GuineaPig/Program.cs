
double foodKilo = double.Parse(Console.ReadLine());
double hayKilo = double.Parse(Console.ReadLine());
double coverKilo = double.Parse(Console.ReadLine());    
double guineasWeightInKilo = double.Parse(Console.ReadLine());

int daysCnt = 30;

for (int currDay = 1; currDay <= 30; currDay++)
{
    foodKilo -= 0.3;

    if (currDay % 2 == 0)
    {
        hayKilo -= 0.05 * foodKilo;
    }

    if (currDay % 3 == 0)
    {
        coverKilo -= guineasWeightInKilo / 3;
    }
}

if (foodKilo > 0 && hayKilo > 0 && coverKilo > 0)
{
    Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodKilo:f2}, Hay: {hayKilo:f2}, Cover: {coverKilo:f2}.");
}
else
{
    Console.WriteLine("Merry must go to the pet store!");
}
