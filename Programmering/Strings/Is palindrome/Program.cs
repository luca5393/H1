namespace Is_palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("eye"));
        }
        static bool IsPalindrome(string inputstring)
        {
            string reversed = new string(inputstring.Reverse().ToArray());

            if (reversed == inputstring) 
            {
                return true;
            }
            return false;
        }
    }
}
