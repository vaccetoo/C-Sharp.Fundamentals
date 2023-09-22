namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCnt = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int coursesNeeded = (int)Math.Ceiling((double)peopleCnt / (double)elevatorCapacity);

            Console.WriteLine(coursesNeeded);
        }
    }
}