
string command = string.Empty;

string endCommand = string.Empty;

double coinsSum = 0;

while ((command = Console.ReadLine()) != "Start")
{
    double currCoins = double.Parse(command);
    
    double[] vallidCoins = { 0.1, 0.2, 0.5, 1, 2 };

    if (!vallidCoins.Contains(currCoins))
    {
        Console.WriteLine($"Cannot accept {currCoins}");
        continue;
    }

    coinsSum += currCoins;
}

if (command == "Start")
{
    while ((endCommand = Console.ReadLine()) != "End")
    {
        string currProduct = endCommand;

        string[] vallidProducts = { "Nuts", "Water", "Crisps", "Soda", "Coke" };

        if (!vallidProducts.Contains(currProduct))
        {
            Console.WriteLine("Invalid product");
            continue;
        }

        double currPrice = 0;

        if (currProduct == "Nuts")
        {
            currPrice = 2.0;
        }
        else if (currProduct == "Water")
        {
            currPrice = 0.7;
        }
        else if (currProduct == "Crisps")
        {
            currPrice = 1.5;
        }
        else if (currProduct == "Soda")
        {
            currPrice = 0.8;
        }
        else if (currProduct == "Coke")
        {
            currPrice = 1.0;
        }

        if (coinsSum >= currPrice)
        {
            Console.WriteLine($"Purchased {currProduct.ToLower()}");
            coinsSum -= currPrice;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }

    if (endCommand == "End")
    {
        Console.WriteLine($"Change: {coinsSum:f2}");
    }
}
