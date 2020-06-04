using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Threading;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetBufferSize(80 , 25);

            //Отрисовка границ поля
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4,Direction.RIGHT);
            snake.Draw();

            while (true) 
            {
                if (Console.KeyAvailable) 
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}
