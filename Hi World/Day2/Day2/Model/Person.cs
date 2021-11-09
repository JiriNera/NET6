using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Model
{
    class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        public int Age()
        {
            DateTime today = DateTime.Today;
            return (int)((today - Birthday).TotalDays / 365);
        }
    }
}
