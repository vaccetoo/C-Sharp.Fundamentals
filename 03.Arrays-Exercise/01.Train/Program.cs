namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] waggons = new int[n];

            for (int i = 0; i < n; i++)
            {
                waggons[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ", waggons));
            Console.WriteLine(waggons.Sum());
        }
    }
}