using System;

namespace OOP.FigureUtils
{
    public class Rectangle : IFigure //реализовываем интерфейс, то есть определяем все методы, которые в нем описаны
    {
        private double a, b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double GetArea()
        {
            return a*b;
        }

        public double GetPerimeter()
        {
            return 2*a + 2*b;
        }

        public void Draw()
        {
            Console.WriteLine("Rectangle = {0}, {1}", a, b);
        }
    }
}
