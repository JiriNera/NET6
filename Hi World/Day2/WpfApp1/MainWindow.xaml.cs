﻿using Day2.Data;
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
            Persondetail pdwindow = new Persondetail(p,this);
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
    }
}