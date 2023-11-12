
string resource = string.Empty;

Dictionary<string, int> resources = new Dictionary<string, int>();

while ((resource = Console.ReadLine()) != "stop")
{
    int quantity = int.Parse(Console.ReadLine());

    if (!resources.ContainsKey(resource))
    {
        resources.Add(resource, quantity);
    }
    else
    {
        resources[resource] += quantity;
    }
}

foreach (var item in resources)
{
    Console.WriteLine($"{item.Key} -> {item.Value}");
}