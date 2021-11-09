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
    }
}
