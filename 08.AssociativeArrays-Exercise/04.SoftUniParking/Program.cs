
using System.Reflection.Metadata;
using System.Security.Cryptography;

int numberOfCommands = int.Parse(Console.ReadLine());

Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

for (int i = 0; i < numberOfCommands; i++)
{
    string currentCommand = Console.ReadLine();

    string[] currentCommandAsArray = currentCommand.Split();

    string command = currentCommandAsArray[0];
    string username = currentCommandAsArray[1];

    if (command == "register")
    {
        string licenseNumber = currentCommandAsArray[2];

        if (!keyValuePairs.ContainsKey(username))
        {
            keyValuePairs.Add(username, licenseNumber);

            Console.WriteLine($"{username} registered {licenseNumber} successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: already registered with plate number {licenseNumber}");
        }
    }
    else if (command == "unregister")
    {
        if (keyValuePairs.ContainsKey(username))
        {
            keyValuePairs.Remove(username);

            Console.WriteLine($"{username} unregistered successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: user {username} not found");
        }
    }
}

foreach (var user in keyValuePairs)
{
    Console.WriteLine($"{user.Key} => {user.Value}");
}