namespace Add_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddAndMultiply(2000000, 4, 1000000));
        }
            
        static int AddAndMultiply(int number1, int number2, int number3)
        {
            try
            {
                return checked((number1 + number2) * number3);
            }
            catch (Exception e)
            { 
                Console.WriteLine("There where an error:"+e.Message);
                return 0;
            }
            
        }

    }
}
