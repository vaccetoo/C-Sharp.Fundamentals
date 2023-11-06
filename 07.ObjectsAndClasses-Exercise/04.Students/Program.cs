
int studentsCount = int.Parse(Console.ReadLine());

List<Student> students = new List<Student>();

for (int i = 0; i < studentsCount; i++)
{
    string[] studentInfo = Console.ReadLine().Split();

    string studentName = studentInfo[0];
    string studentLastName = studentInfo[1];
    double studentGrade = double.Parse(studentInfo[2]);

    Student student = new Student(studentName, studentLastName, studentGrade);

    students.Add(student);
}

foreach (Student student in students.OrderByDescending(x => x.Grade))
{
    Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
}

public class Student
{
    public Student(string firstName, string lastName, double grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public double Grade { get; set; }
}