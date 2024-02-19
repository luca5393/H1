namespace Sum_and_average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumAndAverage(11, 66));
            Console.WriteLine(SumAndAverage(-10, 0));
        }
        static string SumAndAverage(int n, int m)
        {
            if (n > m)
            {
                return "Invalid input";
            }

            int sum = 0;
            int count = 0;

            for (int i = n; i <= m; i++)
            {
                sum += i;
                count++;
            }

            double average = (double)sum / count;

            return $"Sum: {sum}, Average: {average}";
        }
    }
}
