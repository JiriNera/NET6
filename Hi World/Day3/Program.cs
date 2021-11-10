using Day3.Function;
using Day3.Model;
using System;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2d pointA = new Point2d(7, 9);
            Point2d pointB = new Point2d(7, 9);
            Console.WriteLine(pointA);
            Console.WriteLine(pointB);

            var soucet = PointMath.AddPoints(pointA, pointB);
            Console.WriteLine("Soucet: " + soucet);



        }
    }
}
