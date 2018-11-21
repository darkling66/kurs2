using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptions;

namespace LibLake
{
    public class Lake
    {
        protected string type;
        private int depth;
        protected int square;
        protected string name;
        private int age;
        private int pollution;

        public Lake(string type, string name)
        {
            this.type = type;
            this.name = name;
        }
        public int Depth
        {
            get { return depth; }
            set
            {
                if (value > 0)
                    depth = value;
                else
                    throw new InvalidDepthException();
            }
        }
        public int Square
        {
            get { return square; }
            set
            {
                if (value > 0)
                    square = value;
                else
                    throw new InvalidSquareException();
            }


        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                    age = value;
                else
                    throw new InvalidAgeException();
            }
        }
        public int Pollution
        {
            get { return pollution; }
            set
            {
                if (value > 0)
                    pollution = value;
                else
                    throw new InvalidPollutionException();
            }
        }

        public override string ToString()
        {
            return string.Format(
                "Данные про озеро:\n" +
                "Вид: {0}\n" +
                "Имя: {1}\n" +
                "Глубина: {2} м\n" +
                "Площадь: {3} км2\n" +
                "Возраст: {4} млн\n" +
                "Загрязненность: {5}%\n", type, name, Depth, Square, Age, Pollution);
        }
    }
}
