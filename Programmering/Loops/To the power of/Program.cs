namespace To_the_power_of
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToThePowerOf(-2, 3));
        }

        static double ToThePowerOf(double number1, double number2)
        {
            
            return Math.Pow(number1, number2);
        }
    }
}
