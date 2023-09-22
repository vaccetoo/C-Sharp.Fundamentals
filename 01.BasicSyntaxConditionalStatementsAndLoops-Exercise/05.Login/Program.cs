
string username = Console.ReadLine();

string userPassword = string.Empty;

for (int i = username.Length - 1; i >= 0; i--)
{
    userPassword += username[i];
}

string currPassword = string.Empty;

int counter = 0;

while ((currPassword = Console.ReadLine()) != userPassword)
{
    counter++;

    if (counter >= 4)
    {
        Console.WriteLine($"User {username} blocked!");
        break;
    }

    Console.WriteLine("Incorrect password. Try again.");
}

if (currPassword == userPassword)
{
    Console.WriteLine($"User {username} logged in.");
}