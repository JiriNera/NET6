using System;

namespace Hi_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jak se jmenujes?");
            string name = Console.ReadLine();

            Hello(name);

            Calculation z;
        }

        static void Hello(string name)
        {
            string name5p = "";
            if (name == "Jiri")
            {
                name5p = "Jirko";
            }
            else if (name == "Anna")
            {
                name5p = "Anno";
            }
            else if (name == "Matous")
            {
                name5p = "Matousi";
            }
            else
            {
                name5p = name + ", omlouvam se ale tve jmeno neumim sklonovat";
            }
            string pozdrav = "Ahoj " + name5p;
            Console.WriteLine(pozdrav);


        }
        static void Calculation(int z)
        {
            int x = 5;
            int y = x*2+10;
            Console.WriteLine (y);
        }
    }
}
