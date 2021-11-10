using Day3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Function
{
    class PointMath
    {
        public static Point2d AddPoints(Point2d p1,Point2d p2)
        {
            int x = p1.X + p2.X;
            int y = p1.Y + p2.Y;

            return new Point2d(x, y);
        }
    }
}
