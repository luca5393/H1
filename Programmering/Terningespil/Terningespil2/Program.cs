namespace Terningespil2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Terningespil(1));
        }
        static int Terningespil(int terninger)
        {
            Terning dice = new Terning();
            int count = 0;

            while (true)
            {
                bool allSixes = true;

                for (int i = 0; i < terninger; i++)
                {
                    int dieValue = dice.Roll();

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
