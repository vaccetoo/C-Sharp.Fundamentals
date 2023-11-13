
string command = string.Empty;

Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

while ((command = Console.ReadLine()) != "end")
{
    string[] courseInfo = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    string courseName = courseInfo[0];
    string courseStudent = courseInfo[1];

    if (!courses.ContainsKey(courseName))
    {
        courses.Add(courseName, new List<string>());
    }

    courses[courseName].Add(courseStudent);
}

foreach (var course in courses)
{
    Console.WriteLine($"{course.Key}: {course.Value.Count}");

    foreach (var student in course.Value)
    {
        Console.WriteLine($"-- {student}");
    }
}