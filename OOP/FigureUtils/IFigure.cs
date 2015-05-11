namespace OOP.FigureUtils
{
    //Определяем интерфейс, то есть сигнатуру методов, которая должна быть в каждом классе, который будет реализовывать этот интерфейс
    public interface IFigure
    {
        double GetArea();
        double GetPerimeter();
        void Draw();
    }
}
