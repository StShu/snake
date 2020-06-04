using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Text;

namespace snake
{
    class Figura
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        internal bool IsHit(Figura figura)
        {
            foreach (var p in pList) 
            {
                if (figura.IsHit(p)) return true;
            }
            return false;
        }

        private bool IsHit(Point point)
        {
            foreach (var p in pList)
            {
                if (point.IsHit(p)) return true;
            }
            return false;
        }

    }
}
