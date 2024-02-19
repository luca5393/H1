namespace Odd_Man_Out
{
    internal class Program
    { 
        static void Main()
        {
            Console.WriteLine(FindUnpairedElement([9, 3, 9, 3, 9, 7, 9]));
        }

        static int FindUnpairedElement(int[] inputarray)
        {

            Dictionary<int, int> elementCount = new Dictionary<int, int>();

            foreach (int element in inputarray)
            {
                if (elementCount.ContainsKey(element))
                {
                    elementCount[element]++; 
                }
                else
                {
                    elementCount[element] = 1;
                }
            }

            foreach (var kvp in elementCount)
            {
                if (kvp.Value % 2 != 0)
                {
                    return kvp.Key;
                }
            }

            return -1;
        }
    }

}

