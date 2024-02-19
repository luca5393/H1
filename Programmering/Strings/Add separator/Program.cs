namespace Add_separator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddSeparator("ABCD", "^"));
        }
        static string AddSeparator(string inputstring, string seperator)
        {
            string finalstring = "";

            foreach (char c in inputstring)
            {
                finalstring += c+seperator;
            }


            return finalstring;
        }
    }
}
