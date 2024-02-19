namespace Elementary_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ElementaryOperations(1, 1));
        }
        static string ElementaryOperations(int number1, int number2)
        {
            try
            { 
                string divide;
                if (number2 == 0)
                {
                    divide = "Cannot divide by 0";
                }
                else
                {
                    divide = $"{number1 / number2}";
                }

                return $"{checked(number1 + number2)}, {checked(number1 - number2)}, {checked(number1 * number2)}, {checked(divide)}";
            }
            catch (Exception e)
            {
                return "There where an error:" + e.Message;
            }
        }
    }
}
