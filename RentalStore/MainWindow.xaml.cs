﻿using System;
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

namespace RentalStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += Window_Loaded;
        }

        //adding sample data into the instock list and current customers list
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataRepo.InStock = DataRepo.GetMovies();
            DataRepo.CurrentCustomers = DataRepo.GetCustomers();

            frame.NavigationService.Navigate(new Main());
        }
    }
}
