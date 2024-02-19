namespace Terningespil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Terningespil(1));
        }
        static int Terningespil(int terninger)
        {
            Random random = new Random();
            int count = 0;

            while (true)
            {
                bool allSixes = true;

                for (int i = 0; i < terninger; i++)
                {
                    int dieValue = random.Next(1, 7); 

                    if (dieValue != 6)
                    {
                        allSixes = false;
                    }
                }

                count++;

                if (allSixes)
                {
                    break;
                }
            }

            return count;
        }
    }
}
