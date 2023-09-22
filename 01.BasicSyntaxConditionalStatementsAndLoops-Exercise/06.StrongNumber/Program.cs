
int n = int.Parse(Console.ReadLine());

// A number is strong, if the sum of the factorials of each digit is equal to the number itself. 

int numberToCompare = n;
int allFactorialSum = 0;

while (n > 0)
{
    int currDigit = n % 10;
    n = n / 10;

    int currDigitFactorial = 1;

    for (int i = 1; i <= currDigit; i++)
    {
        currDigitFactorial *= i;
    }

    allFactorialSum += currDigitFactorial;
}

if (allFactorialSum == numberToCompare)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
