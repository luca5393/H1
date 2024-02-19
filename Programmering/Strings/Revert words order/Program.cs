namespace Revert_words_order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RevertWordsOrder("John Doe."));
        }
        static string RevertWordsOrder(string inputstring)
        {

            string[] words = inputstring.Split(' ');

            Array.Reverse(words);

            string result = string.Join(' ', words);

            return result;
        }
    }
}
