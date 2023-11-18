
string[] file = Console.ReadLine()
    .Split("\\");

string[] fileInfo = file.Last().Split(".");

string fileName = fileInfo[0];
string fileExtension  = fileInfo[1];

Console.WriteLine($"File name: {fileName}");
Console.WriteLine($"File extension: {fileExtension}");