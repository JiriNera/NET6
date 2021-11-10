using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Model
{
    class Point2d
    {
        
        public int X { get; set; }
        public int Y { get; set; }

        public Point2d(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int Area()
        {
            return X * Y;
        }

        public override string ToString()
        {
            return $"Souřadnice bodu jsou [{X},{Y}], plocha od [0,0] k zadanému bodu je {Area()} jednotek^2";
        }
    }
}
    

