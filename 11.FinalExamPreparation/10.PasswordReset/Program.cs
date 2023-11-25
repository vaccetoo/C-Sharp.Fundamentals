using System;
using System.Text;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string newPassword = input;

        string command = string.Empty;

        while ((command = Console.ReadLine()) != "Done")
        {
            string[] commandInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string commandName = commandInfo[0];

            if (commandName == "TakeOdd")
            {
                StringBuilder oddChars = new StringBuilder();

                for (int i = 1; i < newPassword.Length; i += 2)
                {
                    oddChars.Append(newPassword[i]);
                }

                newPassword = oddChars.ToString();
                Console.WriteLine(newPassword);
            }
            else if (commandName == "Cut")
            {
                int index = int.Parse(commandInfo[1]);
                int length = int.Parse(commandInfo[2]);

                newPassword = newPassword.Remove(index, length);
                Console.WriteLine(newPassword);
            }
            else if (commandName == "Substitute")
            {
                string substring = commandInfo[1];
                string substitute = commandInfo[2];

                if (newPassword.Contains(substring))
                {
                    newPassword = newPassword.Replace(substring, substitute);
                    Console.WriteLine(newPassword);
                }
                else
                {
                    Console.WriteLine("Nothing to replace!");
                }
            }
        }

        Console.WriteLine($"Your password is: {newPassword}");
    }
}
