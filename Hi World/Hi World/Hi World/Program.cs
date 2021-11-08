using System;

namespace Hi_World
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Hi World!");
            Console.WriteLine("to je dneska nuda :D");
            Console.WriteLine("Jak se jmenujes?");
            string name = Console.ReadLine();
            string pozdrav = "S pozdravem " + name;
            Console.WriteLine(pozdrav);
           
        }
    }
}
