namespace Absolute_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AbsoluteValue(-2000000000));
        }
        static int AbsoluteValue(int number1)
        {
            return Math.Abs(number1);
        }
    }
}
