namespace Positive__negative_or_zero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PositiveNegativeOrZero(5.24));
            Console.WriteLine(PositiveNegativeOrZero(0.00));
            Console.WriteLine(PositiveNegativeOrZero(-994.53));
        }
        static string PositiveNegativeOrZero(double number)
        {
            if (number > 0)
            {
                return "positive";
            }
            else if (number == 0)
            {
                return "zero";
            }
            return "negative";
        }
    }
}
