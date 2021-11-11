using Day2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.Data;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Persondetail.xaml
    /// </summary>
    public partial class Persondetail : Window

        
    {
        Person person;
        MainWindow mainWindow;
        bool isNewPerson = false;
        public Persondetail(Person _person,MainWindow _mainWindow,bool _inNewPerson)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            isNewPerson = _inNewPerson;

            if (isNewPerson)
                person = new Person();
            else
                person = _person;
            


            txtFirstName.Text = person.FirstName;
            txtLastName.Text = person.LastName;
            txtBirthDay.Text =person.Birthday.ToShortDateString();
                
         }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            person.FirstName = txtFirstName.Text;
            person.LastName = txtLastName.Text;

            if (isNewPerson)
                DataAccess.AddNewPerson(person);
            else
                DataAccess.SavePeopleToDb(person);

            DataAccess.LoadPeopleFromDb();
            mainWindow.grdPeopel.ItemsSource = DataAccess.people;
            Close();
        }
    }
}
