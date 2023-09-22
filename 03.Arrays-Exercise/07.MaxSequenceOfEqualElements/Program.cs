namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input: 2 1 1 2 3 3 2 2 2 1 	 Output: 2 2 2 

            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int currSequence = 1;
            int longestSequence = 1;

            int number = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                currSequence = 1;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        currSequence++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (currSequence > longestSequence)
                {
                    longestSequence = currSequence;
                    number = array[i];
                }
            }

            int[] longestSequenceArray = new int[longestSequence];

            for (int i = 0; i < longestSequenceArray.Length; i++)
            {
                longestSequenceArray[i] = number;
            }

            Console.WriteLine(string.Join(" ", longestSequenceArray));
        }
    }
}