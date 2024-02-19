namespace Multiplication_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Multiplicationtable();
        }
        static void Multiplicationtable()
        {
            string output = "";
            for (int i = 1; i < 11; i++)
            {
                for(int j = 1; j < 11; j++)
                {
                    output += i * j+"\t";
                }
                Console.WriteLine(output);
                output = "";
            }
        }
    }
}
