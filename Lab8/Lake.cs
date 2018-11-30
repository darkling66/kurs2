using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Lake
    {
        private int depth;
        private int weidth;
        private int age;
        private int pollution;

        public string Type { get; set; }

        public string Name { get; set; }

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

        public int Weidth
        {
            get { return weidth; }
            set
            {
                if (value > 0)
                    weidth = value;
                else
                    throw new InvalidWeidthException();
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
                "Глубина: {1} м\n" +
                "Ширина: {2} км\n" +
                "Имя: {3}\n" +
                "Возраст: {4} млн\n" +
                "Загрязненность: {5}%\n", Type, Depth, Weidth, Name, Age, Pollution);
        }


    }

    public class LakeException : Exception
    {
        public LakeException(string message) : base(message) { }
    }

    public class InvalidDepthException : LakeException
    {
        public InvalidDepthException() : base("Invalid depth input") { }
    }

    public class InvalidWeidthException : LakeException
    {
        public InvalidWeidthException() : base("Invalid weidth input") { }
    }

    public class InvalidAgeException : LakeException
    {
        public InvalidAgeException() : base("Invalid age input") { }
    }

    public class InvalidPollutionException : LakeException
    {
        public InvalidPollutionException() : base("Invalid pollution input") { }
    }
}
