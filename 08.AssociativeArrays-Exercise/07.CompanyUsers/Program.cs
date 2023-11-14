
string command = string.Empty;

Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

while ((command = Console.ReadLine()) != "End")
{
    string[] info = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

    string companyName = info[0];
    string employeeId = info[1];

    if (!companies.ContainsKey(companyName))
    {
        companies.Add(companyName, new List<string>());
    }

    if (companies[companyName].Contains(employeeId))
    {
        continue;
    }

    companies[companyName].Add(employeeId);
}

foreach (var company in companies)
{
    Console.WriteLine($"{company.Key}");

    foreach (var employeeId in company.Value)
    {
        Console.WriteLine($"-- {employeeId}");
    }
}