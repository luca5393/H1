namespace Draw_triangle
{
    internal class Program
    {
        static void Main()
        {
            DrawTriangle();
        }

        static void DrawTriangle()
        {
            for (int i = 0; i < 10; i++)
            {
                
                for (int j = 0; j < 10 - i - 1; j++)
                {
                    Console.Write(" ");
                }

                
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
