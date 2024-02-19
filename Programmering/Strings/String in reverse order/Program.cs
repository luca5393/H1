namespace String_in_reverse_order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringInReverseOrder("qwerty"));
            Console.WriteLine(StringInReverseOrder("oe93 kr"));
        }
        static string StringInReverseOrder(string inputstring)
        {
            return new string(inputstring.Reverse().ToArray());
        }
    }
}
