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
using cinema_hall_management_system.BL;
using Models = cinema_hall_management_system.Model;

namespace cinema_hall_management_system.UI
{
    /// <summary>
    /// Interaction logic for Movies.xaml
    /// </summary>
    public partial class Movies : Window
    {
        public Movies()
        {
            InitializeComponent();
            try
            {
                Movie movie = new Movie();
                movieList.ItemsSource = movie.getMovies();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            
        }

       
    }
}
