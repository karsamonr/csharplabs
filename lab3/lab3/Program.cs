using System;
using System.Linq;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int[] ArrayIn = { 1, 8, 2, 3, 4, 4, 5, 1, 3};
            int[] ArrayOut = RemoveDuplicates(ArrayIn);
            for (int i = 0; i < ArrayOut.Length; i++)
            {
                Console.WriteLine("({0}) = {1}", i, ArrayOut[i]);
            }
        }

        static int[] RemoveDuplicates(int[] Arr)
        {
            // Реалізація вручну
            /*
            int[] uniqueNumbers = new int[Arr.Length];
            int uniqueCount = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < uniqueCount; j++)
                {
                    if (Arr[i] == uniqueNumbers[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    uniqueNumbers[uniqueCount] = Arr[i];
                    uniqueCount++;
                }
            }
            int[] result = new int[uniqueCount];
            Array.Copy(uniqueNumbers, result, uniqueCount);
            return result;
            */
            return Arr.Distinct().ToArray();
        }
    }
}
