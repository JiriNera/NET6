using System;

namespace Hi_World
{
    class Program
    {
        static void Main(string[] args)
        //{
            //console.writeline("jak se jmenujes?");
            //string name = console.readline();

            //hello(name);

            //console.writeline("zadej cele cislo " + name + ":");

            //int x = int.parse(console.readline());


            //console.writeline("vypocet: " + calc(x));


            //ConvertFtoC();
        //}
        {
            Console.WriteLine("Zadej teplotu ve F nebo stiskny x pro ukonceni");
            string input =("");
            while (input != "x")
            {
                 input=ConvertFtoC();
            }
            
        }



        /// <summary>
        /// Converet tem F to C
        /// </summary>
         static string ConvertFtoC()
        {
            Console.WriteLine("Zadej hodnotu F");
            
            string user_input = Console.ReadLine();
            if(user_input == "x")
                return user_input;
            double q = double.Parse(user_input);
            double t = q;

            Console.WriteLine("Prevod " + t + " F na C " + prevod(q));

            return user_input;
        }

        //static void hello(string name)
        //{
        //    string name5p = "";
        //    if (name == "jiri")
        //    {
        //        name5p = "jirko";
        //    }
        //    else if (name == "anna")
        //    {
        //        name5p = "anno";
        //    }
        //    else if (name == "matous")
        //    {
        //        name5p = "matousi";
        //    }
        //    else
        //    {
        //        name5p = name + ", omlouvam se ale tve jmeno neumim sklonovat";
        //    }
        //    string pozdrav = "ahoj " + name5p;
        //    Console.WriteLine(pozdrav);



        //}
        //static int Calc(int x)
        //{
        //   int result = x*2+10;
        //    return result;

        //}

        static double prevod(double q)
        {
            double f = (q - 32) / 1.8;
            return f;
        }

    }
}
