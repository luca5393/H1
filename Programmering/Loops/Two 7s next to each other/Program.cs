namespace Two_7s_next_to_each_other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Two7sNextToEachOther([8, 2, 5, 7, 9, 0, 7, 7, 3, 1]));
        }
        static int Two7sNextToEachOther(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers[0])
                {
                    if (numbers[i] == 7 && numbers[i-1] == 7)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
