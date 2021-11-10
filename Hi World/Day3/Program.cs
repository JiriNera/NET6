using Day3.Function;
using Day3.Model;
using System;
using System.Linq;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point2d pointA = new Point2d(7, 9);
            //Point2d pointB = new Point2d(63, 72);
            //Console.WriteLine(pointA);
            //Console.WriteLine(pointB);

            //var soucet = PointMath.AddPoints(pointA, pointB);
            //Console.WriteLine("Soucet: " + soucet);

            //Console.WriteLine(Day_at_week.DayOfWeek(3));
            //Console.WriteLine(Day_at_week.DayIsWeekend(3));

            //Console.WriteLine(ReturnNumDay.NumDay("Utery"));

            //int[] numbers = { -2079, -498, 2920, -1856, 332, -2549, -674, -120, -992, 2782, 320, -524, 135, 952, 1868, 2509, -230, -138, -904, -480 };

            /// z "numebers" zjistěte:
            /// 1. počet prvků v poli
            /// 2. největší hodnotu
            /// 3. nejmenší hodnotu
            /// 4. průměr
            /// 5. kolik obsahuje pole kladných čísel
            /// 6. kolik obsahuje pole záporných čísel
            /// 7. sumu všech hodnot
            /// 8. sumu kladných hodnot
            /// 

            //var result = numbers
            //.Where(number => number >= 0 && number <= 100)
            //.Where(number => number >= 0)

            //var result =numbers.OrderBy(n => n);
            //var result = numbers.Count();
            //var maxresult = numbers.Max();
            //var minresult = numbers.Min();
            //var pruresult = numbers.Average();
            //var klaresult = numbers.Count(numbers => numbers >= 0);
            //var zapresult = numbers.Count(numbers => numbers <= 0);
            //var sumresult = numbers.Sum();
            //var sumklresult = numbers.Sum(numbers => numbers >= 0);

            //var biggestresult = numbers.OrderByDescending(x => Math.Abs(x)).Take(3);


            //    Console.WriteLine("max number "+string.Join(", ",biggestresult));

            //var result = numbers.Select(numbers => numbers + 10);

            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //var biggestresult = numbers
            //    .Select(x => System.Math.Abs(x))
            //    .OrderByDescending(x => Math.Abs(x))
            //    .Take(3);


            //Console.WriteLine("max number " + string.Join(", ", biggestresult));

            //Console.WriteLine(result + " " + maxresult + " " + minresult + " " + pruresult + " " + klaresult + " " + zapresult + " " + sumresult + " " + sumklresult);

            var numbers = new[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var strings = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = numbers.Select(n => strings[n]);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            var result = strings.Select(slovo => slovo.ToLower() +" "+ slovo.ToUpper());



            foreach (string n in result)
            {
                Console.WriteLine(n);
            }





        }
    }
}