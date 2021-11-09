using Day2.Data;
using Day2.Model;
using System;
using System.Collections.Generic;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Person p = new Person("Petr", "Kubicek", new DateTime(1987, 2, 1));
                p.HomeAddress.City = "Praha";
                p.HomeAddress.Street = "Polni";

                Person p1 = new Person("Anna", "Novakova", new DateTime(1996, 2, 1));
                p1.HomeAddress.City = "Berlin";
                p1.HomeAddress.Street = "Polni";

                Person p2 = new Person("Vasek", "Novak", new DateTime(1999, 2, 1));
                p2.HomeAddress.City = "London";
                p2.HomeAddress.Street = "Polni";

                Person p3 = new Person("Vasek", "Kubicek", new DateTime(1987, 2, 1));
                p3.HomeAddress.City = "Olomouc";
                p3.HomeAddress.Street = "Polni";

                Person p4 = new Person("Jan", "Vel", new DateTime(1966, 2, 1));
                p4.HomeAddress.City = "Olomouc";
                p4.HomeAddress.Street = "Ctvercova";

                Person p5 = new Person("Ondrej", "Good", new DateTime(1999, 2, 1));
                p5.HomeAddress.City = "Tabor";
                p5.HomeAddress.Street = "Ctvercova";

                Person p6 = new Person("Petra", "Letni", new DateTime(1953, 2, 1));
                p6.HomeAddress.City = "Melnik";
                p6.HomeAddress.Street = "HOrni";

                Person p7 = new Person("Petra", "Zimni", new DateTime(1989, 2, 1));
                p7.HomeAddress.City = "Melnik";
                p7.HomeAddress.Street = "Dolni";

                Person p8 = new Person("Petra", "GRRRR", new DateTime(1989, 2, 1));
                p8.HomeAddress.City = "Spodek";
                p8.HomeAddress.Street = "Dolni";

                Person p9 = new Person("Lucka", "Smith", new DateTime(1989, 2, 1));
                p9.HomeAddress.City = "Spolek";
                p9.HomeAddress.Street = "Leva";

                //PersonData.SavePerson(p);

               
                var peopel = PersonData.LoadPeopel();
                Console.WriteLine(peopel.Count);                  



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

                //if (Age1 >= Age2)

                //    Console.WriteLine(p1.FirstName + " " + p1.LastName);

                //else

                //    Console.WriteLine(p2.FirstName + " " + p2.LastName);
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
