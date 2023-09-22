double amountOfMoney = double.Parse(Console.ReadLine());
int studentsCnt = int.Parse(Console.ReadLine());

double lightsabersPrice = double.Parse(Console.ReadLine());
double robesPrice = double.Parse(Console.ReadLine());
double beltsPrice = double.Parse(Console.ReadLine());

double finalPriceForLightsabers = (Math.Ceiling(studentsCnt + 0.1 * studentsCnt)) * lightsabersPrice;
double finalRobesPrice = studentsCnt * robesPrice;

double freeBelts = studentsCnt / 6;
double finalBeltsPrice = (studentsCnt - freeBelts) * beltsPrice;

double finalPrice = finalPriceForLightsabers + finalRobesPrice + finalBeltsPrice;

double moneyNeeded = finalPrice - amountOfMoney;

if (finalPrice > amountOfMoney)
{
    Console.WriteLine($"John will need {moneyNeeded:f2}lv more.");
}
else
{
    Console.WriteLine($"The money is enough - it would cost {finalPrice:f2}lv.");
}
