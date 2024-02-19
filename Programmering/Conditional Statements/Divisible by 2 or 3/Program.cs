namespace Divisible_by_2_or_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(DivisibleBy2Or3(2, 3));
        }
        public static int DivisibleBy2Or3(int number1, int number2)
        {
            try
            {
                if ((number1 % 2 == 0 || number1 % 3 == 0) && (number2 % 2 == 0 || number2 % 3 == 0))
                {
                    return checked(number1 * number2);
                }
                return checked(number1 + number2);
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error: " + e.Message);
                return 0;
            }
        }
    }
}
