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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Persondetail.xaml
    /// </summary>
    public partial class Persondetail : Window
    {
        Person person;

        public Persondetail(Person _person)
        {
            InitializeComponent();

            person = _person;
            txtFirstName.Text = person.FirstName;
            txtLastName.Text = person.LastName;
            txtBirthDay.Text =person.Birthday.ToShortDateString();
                
         }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            person.FirstName = txtFirstName.Text;
            person.LastName = txtLastName.Text;
        }
    }
}
