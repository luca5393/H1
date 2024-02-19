namespace The_biggest_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TheBiggestNumber([190, 291, 145, 209, 280, 200]));
        }
        static int TheBiggestNumber(int[] numbers)
        {
            int biggestnumber = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= biggestnumber)
                {
                    biggestnumber = numbers[i];
                }
            }
            return biggestnumber;
        }
    }
}
