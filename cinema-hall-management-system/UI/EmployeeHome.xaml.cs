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

namespace cinema_hall_management_system.UI
{
    /// <summary>
    /// Interaction logic for EmployeeHome.xaml
    /// </summary>
    public partial class EmployeeHome : Window
    {
        public EmployeeHome()
        {
            InitializeComponent();
        }

        private void moviesButton_Click(object sender, RoutedEventArgs e)
        {
            Movies movies = new Movies();
            movies.Show();
            


        }

        private void cinemaHallButton_Click(object sender, RoutedEventArgs e)
        {
            CinemaHalls ch = new CinemaHalls();
            ch.Show();

        }

        private void showButton_Click(object sender, RoutedEventArgs e)
        {
            new MovieShows().Show();
        }
    }
}
