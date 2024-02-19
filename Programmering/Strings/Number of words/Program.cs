namespace Number_of_words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfWords("This is sample sentence"));
        }
        static int NumberOfWords(string inputstring)
        {

            string[] words = inputstring.Split(' ');
            return words.Length;
        }
    }
}
