namespace If_number_is_even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IfNumberIsEven(721));
            Console.WriteLine(IfNumberIsEven(1248));
        }
        static bool IfNumberIsEven(int number)
        {
            if (number%2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
