namespace ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", ArrayRotation([3, 5, 2, 7, 6], 2)));
        }
        static int[] ArrayRotation(int[] array, int rotations)
        {
            int length = array.Length;
            int[] rotatedArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                int newIndex = (i + rotations) % length;

                rotatedArray[newIndex] = array[i];
            }

            return rotatedArray;
        }
    }
}
