namespace If_greater_than_third_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IfGreaterThanThirdOne([2, 7, 12]));
            Console.WriteLine(IfGreaterThanThirdOne([-5, -8, 50]));
        }
        static bool IfGreaterThanThirdOne(int[] intarray)
        {
            try
            {
                if (checked(intarray[0] + intarray[1]) > intarray[2] || checked(intarray[0] * intarray[1]) > intarray[2])
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("There where an error:" + e.Message);
                return false;
            }
        }
    }
}
