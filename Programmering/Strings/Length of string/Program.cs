namespace Length_of_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfAString("computer"));
            Console.WriteLine(LengthOfAString("ice cream"));
        }
        static int LengthOfAString(string inputstring)
        {
            int count = 0;
            foreach (char c in inputstring)
            {
                count++;
            }

            return count;
        }
    }
}
