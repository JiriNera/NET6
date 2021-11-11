using Day2.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Data;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_detail_osoby_Click(object sender, RoutedEventArgs e)
        {
            var p = (Person)grdPeopel.SelectedItem;
            Persondetail pdwindow = new Persondetail(p,this,false);
            pdwindow.Show();
        }

        //private void LoadInitialDataset()
        //{
        //    using (var db = new PeopelContext())
        //    {
        //        var file = @"C:\Users\Virtualpro\Documents\NET6\Hi World\Day2\Day2\bin\Debug\net5.0\peopel.txt";
        //        var peopel = PersonData.LoadPeopel(file);

        //        db.Peopel.AddRange(peopel);
        //        db.SaveChanges();
        //    }
        //}

        public void WindowMain_Loaded(object sender, RoutedEventArgs e)
        {
            //LoadInitialDataset();
            DataAccess.LoadPeopleFromDb();
            
            grdPeopel.ItemsSource = DataAccess.people;
        }

        private void grdPeopel_Selected(object sender, SelectionChangedEventArgs e)
        {
            btn_detail_osoby.IsEnabled = true;
        }

        private void btn_new_person_Click(object sender, RoutedEventArgs e)
        {
            Persondetail pdwindow = new Persondetail(null, this,true);
            pdwindow.Show();
        }

       
       
        private void txtbox_text_TextChanged(object sender, TextChangedEventArgs e)
        {
            var name = txtbox_text.Text;

            DataAccess.LoadPeopleFromDb();

            grdPeopel.ItemsSource = DataAccess.people.Where(x => x.FirstName.ToLower().Contains(name.ToLower())|| x.LastName.ToLower().Contains(name.ToLower()));
        }

        private void btn_reset_Click(object sender, RoutedEventArgs e)
        {
            txtbox_text.Clear();
        }

        private void grdPeopel_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if(e.PropertyName =="Cars")
            {
                e.Cancel = true;
            }

            if(e.PropertyName =="Brithday")
            {
                
            }
        }
    }
}