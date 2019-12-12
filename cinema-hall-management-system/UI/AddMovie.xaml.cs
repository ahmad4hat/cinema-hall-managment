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
using BL = cinema_hall_management_system.BL;

namespace cinema_hall_management_system.UI
{
    /// <summary>
    /// Interaction logic for AddMovie.xaml
    /// </summary>
    public partial class AddMovie : Window
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        private void btnAddMovie_Click(object sender, RoutedEventArgs e)
        {
            String title = txtTitle.Text;
            String releaseDate = dtRelaseDate.SelectedDate.ToString();
            String description = txtDescription.Text;
            String director = txtDirector.Text;
            String rating = txtRating.Text;
            String duration = txtDuration.Text;
            String genre = txtGenre.Text;
            BL.Movie movie = new BL.Movie();

            try
            {
                movie.addMovie(title, releaseDate, description, duration, genre, director, rating);
            }
            catch (Exception err) 
            {
                MessageBox.Show(err.Message);
            }

        }

        private void txtTitle_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtDuration_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtGenre_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtDirector_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtRating_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

       
    }
}
