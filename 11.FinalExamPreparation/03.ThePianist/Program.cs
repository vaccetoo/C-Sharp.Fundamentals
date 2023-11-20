
using System.Security.Cryptography.X509Certificates;

int numberOfPieces = int.Parse(Console.ReadLine());

List<Piece> pieces = new List<Piece>();

for (int i = 0; i < numberOfPieces; i++)
{
    string[] pieceInfo = Console.ReadLine().Split("|");

    string piece = pieceInfo[0];
    string composer = pieceInfo[1];
    string key = pieceInfo[2];

    Piece currentPiece = new Piece(piece, composer, key);

    pieces.Add(currentPiece);
}

string command = string.Empty;

while ((command = Console.ReadLine()) != "Stop")
{
    string[] commandInfo = command.Split("|");

    string commandName = commandInfo[0];

    if (commandName == "Add")
    {
        string name = commandInfo[1];
        string composer = commandInfo[2];
        string key = commandInfo[3];

        if (!pieces.Any(x => x.Name == name))
        {
            Piece newPiece = new Piece(name, composer, key);

            pieces.Add(newPiece);

            Console.WriteLine($"{name} by {composer} in {key} added to the collection!");

            continue;
        }

        Console.WriteLine($"{name} is already in the collection!");
    }
    else if (commandName == "Remove")
    {
        string nameToRemove = commandInfo[1];

        Piece pieceToRemove = pieces.FirstOrDefault(x => x.Name == nameToRemove);

        if (pieceToRemove != null)
        {
            pieces.Remove(pieceToRemove);

            Console.WriteLine($"Successfully removed {nameToRemove}!");
        }
        else
        {
            Console.WriteLine($"Invalid operation! {nameToRemove} does not exist in the collection.");
        }
    }
    else if (commandName == "ChangeKey")
    {
        string name = commandInfo[1];
        string key = commandInfo[2];

        bool isFound = false;

        foreach (Piece piece in pieces)
        {

            if (piece.Name == name)
            {
                piece.Key = key;
                isFound = true;

                Console.WriteLine($"Changed the key of {name} to {key}!");
            }
        }

        if (!isFound)
        {
            Console.WriteLine($"Invalid operation! {name} does not exist in the collection.");
        }
    }
}

foreach (Piece piece in pieces)
{
    Console.WriteLine($"{piece.Name} -> Composer: {piece.Composer}, Key: {piece.Key}");
}

public class Piece
{
    public Piece(string name, string composer, string key)
    {
        this.Name = name;
        this.Composer = composer;
        this.Key = key;
    }

    public string Name { get; set; }

    public string Composer { get; set; }

    public string Key { get; set; }
}