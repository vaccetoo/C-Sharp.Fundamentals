
string command = string.Empty;

List<Person> people = new List<Person>();

while ((command = Console.ReadLine()) != "End")
{
    string[] personInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string name = personInfo[0];
    string id = personInfo[1];
    int age = int.Parse(personInfo[2]);

    bool personIsChanged = false;

    foreach (var currentPerson in people)
    {
        if (currentPerson.Id == id)
        {
            currentPerson.Age = age;
            currentPerson.Name = name;

            personIsChanged = true;
        }
    }

    if (!personIsChanged)
    {
        Person person = new Person(name, id, age);

        people.Add(person);
    }
}

foreach (var curruntPerson in people.OrderBy(x => x.Age))
{
    Console.WriteLine(curruntPerson);
}

public class Person
{
    public Person(string name, string id, int age)
    {
        Name = name;
        Id = id;
        Age = age;
    }

    public string Name { get; set; }

    public string Id { get; set; }

    public int Age { get; set; }

    public override string ToString()
    {
        return $"{Name} with ID: {Id} is {Age} years old.";
    }
}