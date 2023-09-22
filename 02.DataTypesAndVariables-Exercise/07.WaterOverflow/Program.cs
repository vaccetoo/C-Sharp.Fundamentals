namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;

            int n = int.Parse(Console.ReadLine());

            int waterSum = 0;

            for (int i = 0; i < n; i++)
            {
                int currWaterLiters = int.Parse(Console.ReadLine());

                waterSum += currWaterLiters;

                if (waterSum > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    waterSum -= currWaterLiters;
                }
            }

            Console.WriteLine(waterSum);
        }
    }
}


