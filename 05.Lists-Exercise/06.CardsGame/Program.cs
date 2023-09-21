namespace _6.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> playerA = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> playerB = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (playerA.Count > 0 && playerB.Count > 0)
            {
                if (playerA[0] > playerB[0])
                {
                    playerA.Add(playerA[0]);
                    playerA.Add(playerB[0]);
                }
                else if (playerB[0] > playerA[0])
                {
                    playerB.Add(playerB[0]);
                    playerB.Add(playerA[0]);
                }

                playerA.RemoveAt(0);
                playerB.RemoveAt(0);

                if (playerA.Count == 0)
                {
                    int sum = playerB.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }
                else if (playerB.Count == 0)
                {
                    int sum = playerA.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }
            }
        }
    }
}
