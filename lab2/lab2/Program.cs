using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = i + 1;
            }
            Console.WriteLine("Елементи масиву: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("({0}) = {1}", i, array[i]);
            }
        }
    }
}
