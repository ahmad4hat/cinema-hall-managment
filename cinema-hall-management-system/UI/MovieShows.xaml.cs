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
    /// Interaction logic for MovieShows.xaml
    /// </summary>
    public partial class MovieShows : Window
    {
        public MovieShows()
        {
            InitializeComponent();
            try
            {
                movieShowListList.ItemsSource = new BL.MovieShow().GetMovieShows();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
           
        }

        private void BtnUpdated_Click(object sender, RoutedEventArgs e)
        {
           new MovieShowFindByIdAndUpdate().Show();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            new RemoveMovieShow().Show();
        }

        private void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                movieShowListList.ItemsSource = new BL.MovieShow().GetMovieShows();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }

        private void BtnAddMovieShows_Click(object sender, RoutedEventArgs e)
        {
            new AddMovieShow().Show();
        }
    }
}
