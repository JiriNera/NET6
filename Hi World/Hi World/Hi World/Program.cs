using System;

namespace Hi_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jak se jmenujes?");
            string name = Console.ReadLine();

            hello(name);
            
            Console.WriteLine("Zadej cele cislo " + name + ":");

            int x = int.Parse(Console.ReadLine());

         
            Console.WriteLine("Vypocet: " + Calc(x));

            decimal q = decimal.Parse(Console.ReadLine()); 

            Console.WriteLine(prevod(q));
        }

        static void hello(string name)
        {
            string name5p = "";
            if (name == "jiri")
            {
                name5p = "jirko";
            }
            else if (name == "anna")
            {
                name5p = "anno";
            }
            else if (name == "matous")
            {
                name5p = "matousi";
            }
            else
            {
                name5p = name + ", omlouvam se ale tve jmeno neumim sklonovat";
            }
            string pozdrav = "ahoj " + name5p;
            Console.WriteLine(pozdrav);
            


        }
        static int Calc(int x)
        {
           int result = x*2+10;
            return result;
           
        }

        static decimal prevod(decimal q)
        {
            decimal f = (q - 32) / 1.8;
            return f;
        }

    }
}
