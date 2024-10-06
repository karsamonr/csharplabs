using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Вкажіть координати точки А:\nX = ");
            int A_x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y = ");
            int A_y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Вкажіть координати точки B:\nX = ");
            int B_x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y = ");
            int B_y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Вкажіть координати точки C:\nX = ");
            int C_x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y = ");
            int C_y = Convert.ToInt32(Console.ReadLine());
            Triangle obj = new Triangle(A_x, A_y, B_x, B_y, C_x, C_y);
            obj.ShowTriagle();
            Console.ReadKey();
        }
    }

    class Triangle
    {
        int A_x;
        int A_y;
        int B_x;
        int B_y;
        int C_x;
        int C_y;
        
        public Triangle ()
        {
            A_x = 0;
            A_y = 0;
            B_x = 0;
            B_y = 0;
            C_x = 0;
            C_y = 0;
        }

        public Triangle (int A_x, int A_y, int B_x, int B_y, int C_x, int C_y)
        {
            this.A_x = A_x;
            this.A_y = A_y;
            this.B_x = B_x;
            this.B_y = B_y;
            this.C_x = C_x;
            this.C_y = C_y;
        }
        double CountSide (int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        double CountHalfPerimetr (double a, double b, double c)
        {
            return (a + b + c) / 2;
        }

        double CountArea (double a, double b, double c, double p)
        {
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public void ShowTriagle()
        {
            double a = CountSide(A_x, A_y, B_x, B_y);
            double b = CountSide(B_x, B_y, C_x, C_y);
            double c = CountSide(C_x, C_y, A_x, A_y);
            if (a + b < c || a + c < b || b + c < a)
            {
                Console.WriteLine("Координати трикутника задані не вірно");
                return;
            }
            double p = CountHalfPerimetr(a, b, c);
            double s = CountArea(a, b, c, p);
            Console.WriteLine("Координати трикутника: \nA({0};{1})\nB({2};{3})\nC({4};{5})", A_x, A_y, B_x, B_y, C_x, C_y);
            Console.WriteLine("Площа трикутника: " + s);
        }
    }
}
