using System.Data.SqlTypes;
using System;

namespace How_many_occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HowManyOccurrences("do it now", "do"));
            Console.WriteLine(HowManyOccurrences("do it now do do do", "do"));
        }
        static int HowManyOccurrences(string inputstring, string searchstring)
        {
            int last = 0;
            int count = 0;
            
            while (last != -1)
            {
                count++;
                last = inputstring.IndexOf(searchstring, last + 1);
            }

            return count;
        }
    }
}
