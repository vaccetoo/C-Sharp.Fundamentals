
// input = "{title}, {content}, {author}"

string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

string title = input[0];
string content = input[1];
string author = input[2];

Article article = new Article(title, content, author);

int nunberOfCommands = int.Parse(Console.ReadLine());

for (int i = 0; i < nunberOfCommands; i++)
{
    string[] commandArray = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);

    string command = commandArray[0];
    string newValue = commandArray[1];

    if (command == "Edit")
    {
        article.Edit(newValue);
    }
    else if (command == "ChangeAuthor")
    {
        article.ChangeAuthor(newValue);
    }
    else if (command == "Rename")
    {
        article.Rename(newValue);
    }
}

Console.WriteLine(article);

public class Article
{
    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public string Title { get; set; }

    public string Content { get; set; }

    public string Author { get; set; }

    public void Edit(string content)
    {
        Content = content;
    }

    public void ChangeAuthor(string author)
    {
        Author = author;
    }

    public void Rename(string title)
    {
        Title = title;
    }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}