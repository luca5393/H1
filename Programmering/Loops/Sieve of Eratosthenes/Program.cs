using System;
using System.Text;

namespace Sieve_of_Eratosthenes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SieveOfEratosthenes(30));
        }
        static string SieveOfEratosthenes(int number)
        {
            bool[] isPrime = new bool[number + 1]; 

            for (int i = 2; i <= number; i++)
            {
                isPrime[i] = true;
            }

            for (int p = 2; p * p <= number; p++)
            {
                if (isPrime[p])
                {
                    for (int i = p * p; i <= number; i += p)
                    {
                        isPrime[i] = false; 
                    }
                }
            }

            StringBuilder output = new StringBuilder();
            for (int i = 2; i <= number; i++)
            {
                if (isPrime[i])
                {
                    output.Append(i.ToString()).Append(",");
                }
            }

            return output.ToString();
        }

    }
}
