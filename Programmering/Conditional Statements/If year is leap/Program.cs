namespace If_year_is_leap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IfYearIsLeap(2016));
            Console.WriteLine(IfYearIsLeap(2018));
        }
        static bool IfYearIsLeap(int year)
        {
            if (DateTime.IsLeapYear(year))
            {
                return true;
            }
            return false;
        }
    }
}
