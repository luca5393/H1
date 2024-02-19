namespace Extract_string_M
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ExtractString("##abc##def"));
        }
        static string ExtractString(string stringline)
        {

            int startIndex = stringline.IndexOf("##") + 2;
            int endIndex = stringline.IndexOf("##", startIndex);

            if (startIndex < endIndex)
            {
                return stringline.Substring(startIndex, endIndex - startIndex);
            }
            else
            {
                return "empty string";
            }
            
        }
    }
}
