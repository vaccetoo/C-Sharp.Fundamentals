
int studentsCnt = int.Parse(Console.ReadLine());
int lecturesCnt = int.Parse(Console.ReadLine());
int addBonus = int.Parse(Console.ReadLine());

// On the following lines, you will be receiving the attendance of each student.

double maxBonusPoints = 0;
int finalAttendance = 0;

for (int i = 1; i <= studentsCnt; i++)
{
    int currStudentAttendance = int.Parse(Console.ReadLine());

    double currStudentBonusPoints = ((double)currStudentAttendance / lecturesCnt) * (5 + addBonus);

    if (currStudentBonusPoints > maxBonusPoints)
    {
        maxBonusPoints = currStudentBonusPoints;
        finalAttendance = currStudentAttendance;
    }
}

Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonusPoints)}.");
Console.WriteLine($"The student has attended {finalAttendance} lectures.");
    
