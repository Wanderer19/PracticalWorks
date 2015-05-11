using System;

namespace OOP.FigureUtils
{
    public class Square : IFigure //реализовываем интерфейс, то есть определяем все методы, которые в нем описаны
    {
        private readonly double sideSize;

        public Square(double sideSize)
        {
            this.sideSize = sideSize;
        }

        public double GetArea()
        {
            return sideSize * sideSize;
        }

        public double GetPerimeter()
        {
            return 4 * sideSize;
        }

        public void Draw()
        {
            Console.WriteLine("Square = {0}", sideSize);
        }
    }
}
