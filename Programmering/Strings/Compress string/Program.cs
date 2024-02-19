using System.Text;

namespace Compress_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CompressString("kkkktttrrrrrrrrrr"));
            Console.WriteLine(CompressString("p555ppp7www"));
        }
        static string CompressString(string input)
        {
            string compressed = "";
            char currentChar = input[0];
            int charCount = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == currentChar)
                {
                    charCount++;
                }
                else
                {
                    compressed += currentChar;
                    compressed += charCount;

                    currentChar = input[i];
                    charCount = 1;
                }
            }

            compressed += currentChar;
            compressed += charCount;
            

            return compressed;
        }
    }
}
