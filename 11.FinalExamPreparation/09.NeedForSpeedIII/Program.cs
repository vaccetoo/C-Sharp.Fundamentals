int carsCount = int.Parse(Console.ReadLine());

List<Car> cars = new List<Car>();

for (int i = 0; i < carsCount; i++)
{
    string[] carsInfo = Console.ReadLine()
        .Split("|");

    string model = carsInfo[0];
    int mileage = int.Parse(carsInfo[1]);
    int fuel = int.Parse(carsInfo[2]);

    Car car = new Car(model, mileage, fuel);

    cars.Add(car);
}

string command = string.Empty;

while ((command = Console.ReadLine()) != "Stop")
{
    string[] commandInfo = command
        .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

    string commandName = commandInfo[0];

    if (commandName == "Drive")
    {
        string carModel = commandInfo[1];
        int distance = int.Parse(commandInfo[2]);
        int fuel = int.Parse(commandInfo[3]);

        foreach (Car car in cars)
        {
            if (car.Model == carModel && car.Fuel >= fuel)
            {
                car.Mileage += distance;
                car.Fuel -= fuel;

                Console.WriteLine($"{car.Model} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                if (car.Mileage >= 100000)
                {
                    Console.WriteLine($"Time to sell the {car.Model}!");
                }
            }
            else if (car.Model == carModel && car.Fuel < fuel)
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
        }
    }
    else if (commandName == "Refuel")
    {
        string carModel = commandInfo[1];
        int addFuel = int.Parse(commandInfo[2]);

        foreach (Car car in cars)
        {
            if (car.Model == carModel)
            {
                if (car.Fuel + addFuel > 75)
                {
                    addFuel = 75 - car.Fuel;
                    car.Fuel = 75;
                }
                else
                {
                    car.Fuel += addFuel;
                }

                Console.WriteLine($"{car.Model} refueled with {addFuel} liters");
            }
        }
    }
    else if (commandName == "Revert")
    {
        string carModel = commandInfo[1];
        int kilometers = int.Parse(commandInfo[2]);

        foreach (Car car in cars)
        {
            if (car.Model == carModel)
            {
                car.Mileage -= kilometers;

                if (car.Mileage >= 10000)
                {
                    Console.WriteLine($"{car.Model} mileage decreased by {kilometers} kilometers");
                }
                else
                {
                    car.Mileage = 10000;
                }
            }
        }
    }
}

cars.RemoveAll(car => car.Mileage >= 100000);

foreach (Car car in cars)
{
    Console.WriteLine($"{car.Model} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
}

public class Car
{
    public Car(string model, int mileage, int fuel)
    {
        Model = model;
        Mileage = mileage;
        Fuel = fuel;
    }

    public string Model { get; set; }

    public int Mileage { get; set; }

    public int Fuel { get; set; }
}