using System;
using System.Threading.Tasks;

namespace lab7
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int arraySize = 1000000;
            int multiplier = 3;
            int[] array = new int[arraySize];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            int numberOfTasks = Environment.ProcessorCount;
            int chunkSize = arraySize / numberOfTasks;
            Task[] tasks = new Task[numberOfTasks];

            for (int t = 0; t < numberOfTasks; t++)
            {
                int start = t * chunkSize;
                int end = (t == numberOfTasks - 1) ? arraySize : start + chunkSize;
                tasks[t] = Task.Run(() =>
                {
                    for (int i = start; i < end; i++)
                    {
                        array[i] *= multiplier;
                    }
                });
            }
            Task.WaitAll(tasks);
            Console.WriteLine("Множення завершено.");
            Console.WriteLine($"Перший елемент: {array[0]}");
            Console.WriteLine($"Останній елемент: {array[arraySize - 1]}");
        }
    }
}