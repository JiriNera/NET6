using System;
using System.IO;

namespace Hi_World
{
    class Program
    {
        static void Main(string[] args)
        {
            int age_max = 0;
            string name_oldest = "";
            foreach (var line in File.ReadLines("Lide.txt"))
            {
                string[] items = line.Split(';');
                string name = items[0];
                string age_s = items[1];

                int age = int.Parse(age_s);

                if (age > age_max)
                {
                    age_max = age;
                    name_oldest = name;
                }
            }
            Console.WriteLine($"Nejstarsi je: { name_oldest} ({ age_max})");
        }

        //{
        //    Console.WriteLine("Zadej datum narozeni ve formatu dd.MM.yyyy");
        //    DateTime date = DateTime.Parse(Console.ReadLine());
        //    DateTime now = DateTime.Now;

        //    TimeSpan result = now - date;
        //    TimeSpan numD = result / 365;
        //    Console.WriteLine(numD);


        //}
        ////{
        ////console.writeline("jak se jmenujes?");
        ////string name = console.readline();

        ////hello(name);

        ////console.writeline("zadej cele cislo " + name + ":");

        ////int x = int.parse(console.readline());


        ////console.writeline("vypocet: " + calc(x));


        ////ConvertFtoC();
        ////}
        //static void Temp(string[])
        //{
        //    Console.WriteLine("Zadej teplotu ve F nebo stiskny x pro ukonceni");
        //    string input = ("");
        //    while (input != "x")
        //    {
        //        input = ConvertFtoC();
        //    }

        //}

        ////static void Filltxt(string[])
        ////{
        ////    string a = ("");
        ////    while (a != "x")
        ////    {
        ////        a = Fill();
        ////    }
        ////}
        //static string Fill(string[] x)
        //{
        //    Console.WriteLine("Zadej jmeno a prijmeni nebo ukonci pomoci x");

        //    string name = Console.ReadLine();
        //    if (name == "x")
        //    { return name; }

        //    else if (string.IsNullOrEmpty(name))
        //    { return name; }

        //    else
        //        Console.WriteLine("Zadej svuj vek");
        //    int age = int.Parse(Console.ReadLine());
        //    string[] namesplit = name.Split(" ");
        //    if (namesplit[0] == "X")
        //    { return namesplit[0]; }

        //    File.AppendAllText("Name_age.txt", namesplit[0] + ";" + namesplit[1] + ";" + age + Environment.NewLine);

        //    return namesplit[0];
        //}


        ///// <summary>
        ///// Converet tem F to C
        ///// </summary>
        //static string convertftoc()
        //{
        //    console.writeline("zadej hodnotu f");

        //    string user_input = console.readline();

        //    try
        //    {
        //        double q = double.parse(user_input);
        //        double t = q;

        //        console.writeline("prevod " + t + " f na c " + prevod(q));
        //    }
        //    catch (formatexception ex)
        //    {
        //        if (user_input != "x")
        //            file.appendalltext("errorlog.txt", ex.message + environment.newline);
        //    }
        //    catch (exception ex)
        //    {
        //        file.appendalltext("errorlog.txt", "general exception" + ex.message + environment.newline);
        //    }

        //    return user_input;
        //}

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

        //static double prevod(double q)
        //{
        //    double f = (q - 32) / 1.8;
        //    return f;
        //}


        //    static void CalcAge(string[] def)
        //    {
        //        int x =;
        //        {
        //            int x = Vyp();
        //            Console.WriteLine(x);
        //        }
        //    }
        //    static int Vyp(int age)
        //    {
        //        Console.WriteLine("Zadej rok narozeni:");
        //        DateTime Vek = DateTime.Parse(Console.ReadLine());
        //        DateTime myRok = DateTime.Now;
        //        string rok = myRok.Year.ToString();
        //        int year = int.Parse(rok);

        //        return year;
        //    }
        //}
        //static int AgeSolver(DateTime dateofbirth)
        //{
        //    DateTime today = DateTime.Today;
        //    return (int)((today - dateofbirth).TotalDays / 365);
        //}

        //static int Compare(int x, int y)
        //{
        //    return Math.Max(x, y);

        //}
        //static bool IsEndingOva(string jmeno)
        //{
        //   return jmeno.EndsWith("ová");
        //}

       
        {
            FindOldest();
        }

        private static void FindOldest()
        {
            int age_max = 0;
            string name_oldest = "";
            foreach (var line in File.ReadLines("Lide.txt"))
            {
                string[] items = line.Split(';');
                string name = items[0];
                string age_s = items[1];

                int age = int.Parse(age_s);

                if (age > age_max)
                {
                    age_max = age;
                    name_oldest = name;
                }
            }
            Console.WriteLine($"Nejstarsi je: { name_oldest} ({ age_max})");
        }
    }
}
