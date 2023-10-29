
string[] article = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

int numberOfCommands = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfCommands; i++)
{
    string title = article[0];
    string content = article[1];
    string author = article[2];

    Article currArticle = new Article(title, content, author);  


}

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
}