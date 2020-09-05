using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class FoodCreator
    {
        int mapWidth;
        int mapHeight;
        char sym;

        Random random = new Random();

        public FoodCreator(int x, int y, char ch)
        {
            this.mapWidth = x;
            this.mapHeight = y;
            this.sym = ch;
        }

        public Point CreateFood()
        {
            return new Point(random.Next(2,mapWidth - 2), random.Next(2, mapHeight - 2), sym);
        }
    }
}