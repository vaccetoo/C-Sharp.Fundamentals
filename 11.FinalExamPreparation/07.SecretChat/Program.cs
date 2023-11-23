
using System.Text;

string message = Console.ReadLine();

string command = string.Empty;

while ((command = Console.ReadLine()) != "Reveal")
{
    string[] commandinfo = command.Split(":|:");

    string commandName = commandinfo[0];

    if (commandName == "InsertSpace")
    {
        int index = int.Parse(commandinfo[1]);

        message = message.Insert(index, " ");

        Console.WriteLine(message);
    }
    else if (commandName == "Reverse")
    {
        string substring = commandinfo[1];

        if (message.Contains(substring))
        {

            int startIndex = message.IndexOf(substring);

            message = message.Remove(startIndex, substring.Length);

            string reversedString = new string(substring.Reverse().ToArray());
            message += reversedString;

            Console.WriteLine(message);
        }
        else
        {
            Console.WriteLine("error");
        }
    }
    else if (commandName == "ChangeAll")
    {
        string substring = commandinfo[1];
        string replacment = commandinfo[2];

        message = message.Replace(substring, replacment);

        Console.WriteLine(message);
    }
}

Console.WriteLine($"You have a new text message: {message}");