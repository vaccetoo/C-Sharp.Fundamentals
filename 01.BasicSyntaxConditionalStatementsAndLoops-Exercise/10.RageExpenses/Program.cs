
int lostGamesCnt = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());

int headsetsCnt = 0;
int mousesCnt = 0;
int keyboardsCnt = 0;
int displaysCnt = 0;

for (int i = 1; i <= lostGamesCnt; i++)
{
    if (i % 2 == 0)
    {
        headsetsCnt++;
    }
    if (i % 3 == 0)
    {
        mousesCnt++;
    }
    if(i % 6 == 0)
    {
        keyboardsCnt++;

        if (keyboardsCnt % 2 == 0)
        {
            displaysCnt++;
        }
    }
}

double finalHeadsetPrice = headsetsCnt * headsetPrice;
double finalMousesPrice = mousesCnt * mousePrice;
double finalKeyboardsPrice = keyboardsCnt * keyboardPrice;
double finalDisplayPrice = displaysCnt * displayPrice;

double totalPrice = finalHeadsetPrice + finalMousesPrice + finalKeyboardsPrice + finalDisplayPrice;

Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
