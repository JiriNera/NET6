using Day2.Model;
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
                var peoplelist = db.Peopel.ToList();

                people = new ObservableCollection<Person>(peoplelist);
            }
       }

    }
}
