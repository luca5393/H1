namespace Celsius_to_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CtoF(1));
        }
        static string CtoF(double Celsius)
        {
            try
            {
                if (Celsius < -271.15)
                {
                return "Temperature below absolute zero!";
                }
                Celsius = Celsius * 9 / 5 + 32;
                return $"T = {checked(Celsius)}F";

            }
            catch (Exception e)
            {
                return "There where an error:" + e.Message;
            }
        }
    }
}
