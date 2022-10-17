using Snake;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.SetWindowSize(80, 25);
        Console.SetBufferSize(80, 25);

        //Отрисовка рамочки
        GorizontalLine upLine = new GorizontalLine(0, 78, 0, '+');
        GorizontalLine downLine = new GorizontalLine(0, 78, 24, '+');
        VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
        VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
        upLine.Drow();
        downLine.Drow();
        leftLine.Drow();
        rightLine.Drow();
        
        //Отрисовка точек
      
        Point p = new Point(4, 5, '*');

        Snakee snake = new Snakee(p, 4, Direction.RIGHT);
        snake.Drow();
        snake.Move();
    }
}