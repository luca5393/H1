namespace Swap_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SwapTwoNumbers(87, 45));
            Console.WriteLine(SwapTwoNumbers(-13, 2));
        }
        static string SwapTwoNumbers(int number1, int number2)
        {

            int number1store = number1;

            int number2store = number2;

            number1 = number2store;

            number2 = number1store;

            return $"Before: a = {number1store}, b = {number2store}; After: a = {number1}, b = {number2}";
        }
    }
}
