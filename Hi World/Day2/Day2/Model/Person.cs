using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Model
{
    class Person
    {
        public Person()
        {

        }

        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;            
        }

        public Person(string firstname, string lastname,DateTime dob)
        {
            FirstName = firstname;
            LastName = lastname;
            Birthday = dob;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        public int Age()
        {
            DateTime today = DateTime.Today;
            return (int)((today - Birthday).TotalDays / 365);
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
