
string message = Console.ReadLine();

string command = string.Empty;

while ((command = Console.ReadLine()) != "Decode")
{
    string[] commandInfo = command.Split("|");

    string commandName = commandInfo[0];

    if (commandName == "Move")
    {
        int n = int.Parse(commandInfo[1]);

        string stringToMove = message.Substring(0, n);
        message = message.Remove(0, n);
        message += stringToMove;
    }
    else if (commandName == "Insert")
    {
        int index = int.Parse(commandInfo[1]);  
        string stringToInsert = commandInfo[2];

        message = message.Insert(index, stringToInsert);
    }
    else if (commandName == "ChangeAll")
    {
        string stringToChange = commandInfo[1];
        string newString = commandInfo[2];

        message = message.Replace(stringToChange, newString);
    }
}

Console.WriteLine($"The decrypted message is: {message}");