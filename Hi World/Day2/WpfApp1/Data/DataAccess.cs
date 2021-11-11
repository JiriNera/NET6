using Day2.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data
{
    class DataAccess
    {
       public static ObservableCollection<Person> people = new ObservableCollection<Person>();

       public static void LoadPeopleFromDb()
       {
            using (var db = new PeopelContext())
            {
                var peoplelist = db.Peopel
                    .Include(x=>x.HomeAddress)
                    .Include(x=>x.Cars)
                    .ToList();

                people = new ObservableCollection<Person>(peoplelist);
            }
            
       }
        public static void SavePeopleToDb(Person personToSave)
        {
            using (var db = new PeopelContext())
            {
               var dbperson = db.Peopel.Find(personToSave.Id);

                dbperson.FirstName = personToSave.FirstName;
                dbperson.LastName = personToSave.LastName;

                db.SaveChanges();
            }
        }
    }
}
