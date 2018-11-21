using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibSmallLake;
using LibBigLake;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallLake Nicaragua = new SmallLake("Природное", "Никарагуа");
            Nicaragua.Depth = 45;
            Nicaragua.Square = 8157;
            Nicaragua.Age = 10;
            Nicaragua.Pollution = 30;
            Console.WriteLine(Nicaragua);
            BigLake Baikal = new BigLake("Природное", "Байкал");
            Baikal.Depth = 1642;
            Baikal.Square = 31722;
            Baikal.Age = 20;
            Baikal.Pollution = 20;
            Console.WriteLine(Baikal);
            Console.ReadKey();
        }
    }
}