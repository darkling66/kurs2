﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Lake
    {
        private string type;
        private int depth;
        private int weidth;
        private string name;
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
                 "Данные про Озеро:\n" +
                "Вид: {0}\n" +
                "Глубина: {1} м\n" +
                "Ширина: {2} км\n" +
                "Имя: {3}\n" +
                "Возраст: {4} млн\n" +
                "Загрязненность: {5}%\n", type, Depth, Weidth, name, Age, Pollution);
        }
  
        
    }

    class LakeException : Exception
    {
        public LakeException(string message) : base(message) { }
    }
    class InvalidDepthException : LakeException
    {
        public InvalidDepthException() : base("Invalid depth input") { }
    }
    class InvalidWeidthException : LakeException
    {
        public InvalidWeidthException() : base("Invalid weidth input") { }
    }
    class InvalidAgeException : LakeException
    {
        public InvalidAgeException() : base("Invalid age input") { }
    }
    class InvalidPollutionException : LakeException
    {
        public InvalidPollutionException() : base("Invalid pollution input") { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lake Baikal = new Lake("Природное", "Байкал");
            Baikal.Depth = 1642;
            Baikal.Weidth = 79;
            Baikal.Age = 20;
            Baikal.Pollution = 20;
            Console.WriteLine(Baikal);
            Console.ReadKey();
        }
    }
}