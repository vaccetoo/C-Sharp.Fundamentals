namespace _5.PrintPartOfTheASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            for (char i = (char)n; i <= n2; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
