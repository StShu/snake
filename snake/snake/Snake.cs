﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake : Figura
    {
        public Direction direction;

        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++) 
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);           
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNexPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNexPoint() 
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey key) {
            switch (key)
            {
                case ConsoleKey.LeftArrow: direction = Direction.LEFT; break;
                case ConsoleKey.RightArrow: direction = Direction.RIGHT; break;
                case ConsoleKey.UpArrow: direction = Direction.UP; break;
                case ConsoleKey.DownArrow: direction = Direction.DOWN; break;
            }
        }
    }
}