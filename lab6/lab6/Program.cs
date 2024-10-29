using System;

namespace lab6
{
    class Program
    {
        public delegate double MyDelegate(double a, double b);

        static void Main()
        {
            MyDelegate mult = (a, b) => a * b;

            double result1 = mult(2, 6);
            double result2 = mult(10, 0.5);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}