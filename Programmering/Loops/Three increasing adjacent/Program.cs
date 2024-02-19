namespace Three_increasing_adjacent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ThreeIncreasingAdjacent([45, 23, 44, 68, 65, 70, 80, 81, 82]));
        }
        static bool ThreeIncreasingAdjacent(int[] numbers)
        {

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers[0])
                {
                    if (numbers[i] != numbers[1])
                    {
                        if (numbers[i - 2] == (numbers[i - 1] - 1) && numbers[i - 1] == (numbers[i] - 1))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
