using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Model
{
    public class Person
    {
        
        public Person()
        {
            HomeAddress = new Address();
        }

        public Person(string firstname, string lastname)
        {
            HomeAddress = new Address();
            FirstName = firstname;
            LastName = lastname;            
        }

        public Person(string firstname, string lastname,DateTime dob)
        {
            HomeAddress = new Address();
            FirstName = firstname;
            LastName = lastname;
            Birthday = dob;
        }

        public int Id { get; set; }

        [MaxLength(200)]
        public string FirstName { get; set; }

        [MaxLength(200)]
        public string LastName { get; set; }

        public Address HomeAddress { get; set; } = new Address();

        public List<Cars> Cars { get; set; } = new List<Cars>();

        [NotMapped]
        public int CarsCount { get { return Cars.Count; } }

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
