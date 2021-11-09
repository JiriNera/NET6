using Day2.Model;
using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Person p = new Person("Petr", "Kubicek", new DateTime(1987, 2, 1));
                p.HomeAddress = new Address("Praha","ceska");
                p.HomeAddress.City = "Praha";

            }

            {
                Person p1 = new Person();


                p1.FirstName = "John";
                p1.LastName = "Doe";
                p1.Birthday = new DateTime(1999, 5, 12);
                int Age1 = p1.Age();

                Person p2 = new Person();

                p2.FirstName = "Jiri";
                p2.LastName = "Ko";
                p2.Birthday = new DateTime(2000, 6, 19);
                int Age2 = p2.Age();

                if (Age1 >= Age2)

                    Console.WriteLine(p1.FirstName + " " + p1.LastName);

                else

                    Console.WriteLine(p2.FirstName + " " + p2.LastName);
            }

            {
                Cars c1 = new Cars();
                c1.SPZ = "549fde6";
                c1.Barva = "modra";
                c1.KM = 136970;
            }
        }
    }
}
