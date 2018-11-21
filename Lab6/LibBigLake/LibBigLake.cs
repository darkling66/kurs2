using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibLake;
using Exceptions;

namespace LibBigLake
{
    public class BigLake : Lake
    {
        public new int Square
        {
            get { return square; }
            set
            {
                if (value > 0 && value > 30000)
                    square = value;
                else
                    if (value < 0)
                    throw new InvalidSquareException();
                else
                    throw new InvalidBigLakeSquareException();
            }

        }
        public BigLake(string type, string name) : base(type, name) { }

        public override string ToString()
        {
            return string.Format(
                "Данные про большое озеро:\n" +
                "Вид: {0}\n" +
                "Имя: {1}\n" +
                "Глубина: {2} м\n" +
                "Площадь: {3} км2\n" +
                "Возраст: {4} млн\n" +
                "Загрязненность: {5}%\n", type, name, Depth, Square, Age, Pollution);
        }
    }
}
