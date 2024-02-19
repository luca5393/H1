using System.Text;

namespace Sort_characters_descending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SortCharactersDescending("onomatopoeia"));
            Console.WriteLine(SortCharactersDescending("fohjwf42os"));
        }
        static string SortCharactersDescending(string inputstring)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(inputstring);

            Array.Sort(asciiBytes);
            Array.Reverse(asciiBytes);

            string result = "";

            for (int i = 0; i < asciiBytes.Length; i++)
            {
                result += Convert.ToChar(asciiBytes[i]);
            }
            return result;
        }
    }
}
