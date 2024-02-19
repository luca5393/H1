namespace The_cube_of
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TheCubeOf(2));
            Console.WriteLine(TheCubeOf(-5.5));
        }
        static double TheCubeOf(double number)
        {
            try
            {
                return checked(number * number * number);
            }
            catch (Exception e)
            {
                Console.WriteLine("There where an error:" + e.Message);
                return 0;
            }
        }
    }
}
