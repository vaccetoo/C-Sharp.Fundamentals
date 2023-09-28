using System.Diagnostics;

class Exam
{
    static void Main()
    {
        string command = string.Empty;
        double priceWithTaxes = 0;
        double priceWithoutTaxes = 0;
        double allTaxes = 0;

        while ((command = Console.ReadLine()) != "special")
        {
            if (command == "regular")
            {
                break;
            }

            double currPrice = double.Parse(command);

            if (currPrice < 0)
            {
                Console.WriteLine("Invalid price!");
                continue;
            }

            priceWithoutTaxes += currPrice;
            double currTax = 0.2 * currPrice;
            allTaxes += currTax;
            priceWithTaxes += (currTax + currPrice);
        }

        if (command == "special")
        {
            double discount = 0.1 * priceWithTaxes;
            priceWithTaxes -= discount;
        }

        if (priceWithTaxes == 0)
        {
            Console.WriteLine("Invalid order!");
        }
        else
        {
            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {priceWithoutTaxes:f2}$");
            Console.WriteLine($"Taxes: {allTaxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {priceWithTaxes:f2}$");
        }
    }
}
