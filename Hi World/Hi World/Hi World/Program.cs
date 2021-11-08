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
    }
}
