using System.Diagnostics;

int peopleCnt = int.Parse(Console.ReadLine());

string groupType = Console.ReadLine();

string day = Console.ReadLine();

double finalPrice = 0;

if (groupType == "Students") // For Students – if the group is 30 or more people, you should reduce the total price by 15%. 
{
    if (day == "Friday")
    {
        finalPrice = peopleCnt * 8.45;
    }
    else if (day == "Saturday")
    {
        finalPrice = peopleCnt * 9.80;
    }
    else if (day == "Sunday")
    {
        finalPrice = peopleCnt * 10.46;
    }

    if (peopleCnt >= 30)
    {
        finalPrice -= finalPrice * 0.15;
    }
}
else if (groupType == "Business") // For Business – if the group is 100 or more people, 10 of the people stay for free. 
{
    if (day == "Friday")
    {
        finalPrice = peopleCnt * 10.90;
    }
    else if (day == "Saturday")
    {
        finalPrice = peopleCnt * 15.60;
    }
    else if (day == "Sunday")
    {
        finalPrice = peopleCnt * 16.00;
    }

    if (peopleCnt >= 100)
    {
        double singlePrice = finalPrice / peopleCnt;

        finalPrice -= singlePrice * 10;
    }
}
else if (groupType == "Regular") // For Regular – if the group is between 10 and 20  people (both inclusively), reduce the total price by 5%. 
{
    if (day == "Friday")
    {
        finalPrice = peopleCnt * 15.00;
    }
    else if (day == "Saturday")
    {
        finalPrice = peopleCnt * 20.00;
    }
    else if (day == "Sunday")
    {
        finalPrice = peopleCnt * 22.50;
    }

    if (peopleCnt >= 10 && peopleCnt <= 20)
    {
        finalPrice -= finalPrice * 0.05;
    }
}

Console.WriteLine($"Total price: {finalPrice:f2}");