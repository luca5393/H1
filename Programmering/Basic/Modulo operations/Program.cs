namespace Modulo_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ModuloOperations(8, 5, 2));
        }
        static string ModuloOperations(int number1, int number2, int number3)
        {
            try
            {
                return $"{number1 % number2 % number3}";
            }
            catch (Exception e)
            {
                return "There where an error:" + e.Message;
            }
        }
    }
}
