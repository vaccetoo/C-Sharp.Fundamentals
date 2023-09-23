
// Three employees are working in the reception all day.

int employeesCnt = 3;

int currEmployeeEfficiency = 0; // The number of students that can answer per hour.
int efficiencyTogether = 0; // The number of students that all together can answer per hour.

for (int i = 0; i < employeesCnt; i++)
{
    currEmployeeEfficiency = int.Parse(Console.ReadLine());

    efficiencyTogether += currEmployeeEfficiency;
}

int studentsCnt = int.Parse(Console.ReadLine());

// Every fourth hour, all employees have a break, so they don't work for an hour. 

int neededHours = 0;

while (studentsCnt > 0)
{
    studentsCnt -= efficiencyTogether;
    neededHours++;

    if (neededHours % 4 == 0)
    {
        neededHours++;
    }
}

Console.WriteLine($"Time needed: {neededHours}h.");
