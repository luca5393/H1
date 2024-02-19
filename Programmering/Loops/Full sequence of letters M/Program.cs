namespace Full_sequence_of_letters_M
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FullSequenceOfLetters("ds"));
        }
        static string FullSequenceOfLetters(string input)
        {
            char startChar = input[0];
            char endChar = input[1];

            // Create a range of characters from startChar to endChar
            string result = "";
            for (char c = startChar; c <= endChar; c++)
            {
                result += c;
            }

            return result;
        }
    }
}
