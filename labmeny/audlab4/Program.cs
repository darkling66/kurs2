using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        const double StartX = 10.3;
        const double dX = 0.7;
        static double Function(double x)
        {
            return 23 * Math.Pow(Math.Sin(Math.Pow(2.76 * x, 3)) * Math.Pow(0.5 * x, 5), 2) + 2 * (2.76 * x) + Math.Cos((2.76 * x) * (0.5 * x));
        }
        static void Main(string[] args)
        {
            double x = StartX;
            double[,] arr = new double[5, 5];
            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                for (int j = arr.GetLowerBound(1); j <= arr.GetUpperBound(1); j++)
                {
                    arr[i, j] = Function(x);
                    x += dX;
                }
            }
            Console.WriteLine("Вiдсортованi за спаданням значення масиву: ");
            Console.WriteLine();
            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                for (int j = arr.GetLowerBound(1); j <= arr.GetUpperBound(1); j++)
                {
                    for (int q = i; q <= arr.GetUpperBound(0); q++)
                    {
                        for (int w = (q == i) ? j : 0; w <= arr.GetUpperBound(1); w++)
                        {
                            if (arr[i, j] < arr[q, w])
                            {
                                double temp = arr[q, w];
                                arr[q, w] = arr[i, j];
                                arr[i, j] = temp;
                            }
                        }
                    }
                    arr[i, j] = Math.Round(arr[i, j], 4);
                    Console.Write(" " + arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            double aMin = 0;
            double aMax = 0;
            double aAvg = 0;
            double sum = 0;
            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                for (int j = arr.GetLowerBound(1); j <= arr.GetUpperBound(1); j++)
                {
                    aMin = arr[arr.GetUpperBound(0), arr.GetUpperBound(1)];
                    aMax = arr[arr.GetLowerBound(0), arr.GetLowerBound(1)];
                    aAvg += arr[i, j];
                }
            }
            aAvg = aAvg / arr.Length;
            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                for (int j = arr.GetLowerBound(1); j <= arr.GetUpperBound(1); j++)
                {
                    if (arr[i, j] >= aMin && arr[i, j] <= aMin + 0.1 * aMin)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.WriteLine("Мiнiмальне значення масиву: {0:0.0000}", aMin);
            Console.WriteLine("Максимальне значення масиву: {0:0.0000}", aMax);
            Console.WriteLine("Середнє значення масиву: {0:0.0000}", aAvg);
            Console.WriteLine("Сума елементiв в дiапазонi: {0:0.0000}", sum);
            Console.ReadLine();
        }
    }
}