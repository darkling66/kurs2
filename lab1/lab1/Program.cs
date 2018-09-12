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
            Console.Write("Введiть початкове значення Xmin: ");
            string sxMin = Console.ReadLine();
            double xMin = Double.Parse(sxMin);
            Console.Write("Введiть кiнцеве значення Xmax: ");
            string sxMax = Console.ReadLine();
            double xMax = double.Parse(sxMax);
            Console.Write("Введiть прирiст dX: ");
            string sdx = Console.ReadLine();
            double dx = double.Parse(sdx);
            double x = xMin;
            double y;
            double sum = 0;
            while (x <= xMax)
            {
                double x1 = x;
                double x2 = 3 * x;
                y = (Math.Sqrt(Math.Pow(Math.Cos(x1), 3) + x2)) / (Math.Pow(x1, 13) + (3 / Math.Cos(x2)));
                Console.WriteLine("x = {0}\t\t y = {1}", x, y);
                x += dx;
                sum += y;
            }
            Console.WriteLine("Sum = {0}", sum);
            if (Math.Abs(x - xMax - dx) > 0.0001)
            {
                y = (Math.Sqrt(Math.Pow(Math.Cos(xMax), 3) + xMax)) / (Math.Pow(xMax, 13) + (3 / Math.Cos(xMax)));
                Console.WriteLine("x = {0}\t\t y = {1}", xMax, y);
               
            }
            Console.ReadKey();

        }
    }
}
