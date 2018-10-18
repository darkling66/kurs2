using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_1
{
    public delegate double FuncDelegate(double x);
    class Program
    {
        static int Menu()
        {
            Console.WriteLine("Обчислення iнтегралу");
            Console.WriteLine("0. Метод лiвих прямокутникiв");
            Console.WriteLine("1. Метод правих прямокутникiв");
            Console.WriteLine("2. Метод центральних прямокутникiв");
            var res = Console.ReadLine();
            return Convert.ToInt32(res);
        }

        public static double QuadCentral(double a, double b, double n, FuncDelegate func)
        {
            Console.WriteLine("Метод центральних прямокутникiв");
            double h = (b - a) / n;
            double q = 0;
            for (double x = a; x < b; x += h)
            {
                q += func(x + h / 2);
            }
            return q * h;
        }

        public static double QuadLeft(double a, double b, double n, FuncDelegate func)
        {
            Console.WriteLine("Метод лiвих прямокутникiв");
            double h = (b - a) / n;
            double y1;
            double x1;
            double Intgrl = 0;
            for (int i = 0; i < n; i++)
            {
                x1 = a + i * h;
                y1 = func(x1);
                Intgrl += y1 * h;
            }
            return Intgrl;
        }

        public static double QuadRight(double a, double b, double n, FuncDelegate func)
        {
            Console.WriteLine("Метод правих прямокутникiв");
            double h = (b - a) / n;
            double y1;
            double x1;
            double Intgrl = 0;
            for (int i = 1; i <= n; i++)
            {
                x1 = a + i * h;
                y1 = func(x1);
                Intgrl += y1 * h;
            }
            return Intgrl;
        }

        delegate double QuadDelegate(double a, double b, double n, FuncDelegate func);

        static double F(double x)
        {
            return (Math.Pow(Math.Sin(x * 2), 3) + 45 + (5 * x)) / (Math.Pow((2 * (2 * x)), 4) + (4 * x));
        }
        static void Main(string[] args)
        {
            QuadDelegate[] menu = { QuadLeft, QuadRight, QuadCentral };
            while (true)
            {
                Console.Write("Введiть початок вiдрiзку iнтегрування a: ");
                string sa = Console.ReadLine();
                double a = double.Parse(sa);
                Console.Write("Введiть кiнець вiдрiзку iнтегрування b: ");
                string sb = Console.ReadLine();
                double b = double.Parse(sb);
                Console.Write("Введiть кiлькiсть дiлянок n: ");
                string sn = Console.ReadLine();
                double n = double.Parse(sn);
         
                QuadDelegate q = menu[Menu()];
                double r = q(a, b, n, F);
                Console.WriteLine("Integral: [{0}, {1}] = {2}", a, b, r);
                Console.WriteLine();
            }
        }
    }
}
}
