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
using ProjectB.Models;
using ProjectB.Models.DB;

namespace ProjectB
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

        private void showTop5_Click(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = DAO.getTopFiveRented();
        }

        private void showLeast5_Click(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = DAO.leastFiveRentedModel();
        }

        private void monthlySales_Click(object sender, RoutedEventArgs e)
        {
            string Month = (monthComboBox.Text);
            string Year = (yearComboBox.Text);

            if (DAO.getMonthlySales(Month, Year).Count() > 0)
            {
                grid.ItemsSource = DAO.getMonthlySales(Month, Year);
                MessageBox.Show("Data Found!");
            }
            else
            {
                MessageBox.Show("No Data!");
                grid.ItemsSource = null;
            }
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            string model = modelComboBox.Text.ToString();
            DateTime start;
            DateTime end;

            if (fromDatePicker.SelectedDate == null || toDatePicker.SelectedDate == null)
                MessageBox.Show("Enter date");
            else if (string.IsNullOrEmpty(model))
                MessageBox.Show("Select Model");
            else
            {
                start = fromDatePicker.SelectedDate.Value.Date;
                end = toDatePicker.SelectedDate.Value.Date;

                if (DAO.getModelSales(model, start, end).Count() > 0)
                {
                    grid.ItemsSource = DAO.getModelSales(model, start, end);
                    MessageBox.Show("Data Found!");
                }
                else
                {
                    MessageBox.Show("No Data!");
                    grid.ItemsSource = null;
                }
            }
        }
    }
}
