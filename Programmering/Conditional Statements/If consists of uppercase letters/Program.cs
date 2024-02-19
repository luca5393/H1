namespace If_consists_of_uppercase_letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IfConsistsOfUppercaseLetters("xyz"));
            Console.WriteLine(IfConsistsOfUppercaseLetters("DOG"));
        }
        static bool IfConsistsOfUppercaseLetters(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (!Char.IsUpper(word[i]))
                {
                    return false;
                }
                    
            }
            return true;

        }
    }
}
