﻿using System;

namespace OOP.FigureUtils
{
    public class Triangle : IFigure //реализовываем интерфейс, то есть определяем все методы, которые в нем описаны
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double GetArea()
        {
            var p = GetPerimeter();
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double GetPerimeter()
        {
            return a + b + c;
        }

        public void Draw()
        {
            Console.WriteLine("Triangle = {0}, {1}, {2}", a, b, c);
        }
    }
}
