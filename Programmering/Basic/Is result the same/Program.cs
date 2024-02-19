namespace Is_result_the_same
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsResultTheSame(2+2, 2*2));
            Console.WriteLine(IsResultTheSame(9 / 3, 16-1));
        }
        static bool IsResultTheSame(int number1, int number2)
        {
            try
            {


                if (checked(number1 == number2))
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("There where an error:" + e.Message);
                return false;
            }
        }
    }
}
