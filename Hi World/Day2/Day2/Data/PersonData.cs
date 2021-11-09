using Day2.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Data
{
    class PersonData
    {
        const string persondatafile= "peopel.txt";
       

        public static void SavePerson(Person person)
        {

            var line = $"{person.FirstName};{person.LastName};{person.Birthday};{person.HomeAddress.City};{person.HomeAddress.Street}";
            line += Environment.NewLine;
            File.AppendAllText(persondatafile, line);

        }

        public static List<Person> LoadPeopel()
        {
            var peopel = new List<Person>();

            var lines =File.ReadAllLines(persondatafile);

            foreach(var line in lines)
            {
                var items = line.Split(';');
                Person p = new Person();
                p.FirstName = items[0];
                p.LastName = items[1];
                p.Birthday = DateTime.Parse(items[2]);
                p.HomeAddress.City = items[3];
                p.HomeAddress.Street = items[4];

                peopel.Add(p);
            }

            return peopel;
        }
    }
}
