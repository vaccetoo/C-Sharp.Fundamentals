
int numberOfCommands = int.Parse(Console.ReadLine());  

Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

for (int i = 0; i < numberOfCommands; i++)
{
    string studentName = Console.ReadLine();
    double studentGrade = double.Parse(Console.ReadLine());

    if (!students.ContainsKey(studentName))
    {
        students.Add(studentName, new List<double>());
    }

    students[studentName].Add(studentGrade);
}

foreach (var student in students.Where(grade => grade.Value.Sum() / grade.Value.Count >= 4.50))
{
    Console.WriteLine($"{student.Key} -> {student.Value.Sum() / student.Value.Count:f2}");
}