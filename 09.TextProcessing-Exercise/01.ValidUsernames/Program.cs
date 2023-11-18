

string[] usernames = Console.ReadLine()
    .Split(", ");

foreach (string username in usernames)
{
    if (IsValidUsername(username))
    {
        Console.WriteLine(username);
    }
}

bool IsValidUsername(string username)
{
    if (username.Length < 3 || username.Length > 16)
    {
        return false;
    }

    foreach (char character in username)
    {
        if (character != '-' && 
            character != '_' && 
            (character < 'a' || character > 'z') &&
            (character < 'A' || character > 'Z') &&
            (character < '0' || character > '9'))
        {
            return false;
        }
    }

    return true;
}