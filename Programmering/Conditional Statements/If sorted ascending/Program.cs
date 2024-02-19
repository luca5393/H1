namespace If_sorted_ascending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IfSortedAscending([3, 7, 10]));
            Console.WriteLine(IfSortedAscending([74, 62, 99]));
        }
        static bool IfSortedAscending(int[] numbers)
        {
            if (numbers[0] < numbers[1] && numbers[1] < numbers[2])
            {
                return true;
            }
            return false;
        }
    }
}
