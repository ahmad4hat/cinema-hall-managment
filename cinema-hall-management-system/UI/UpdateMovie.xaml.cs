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
using Models = cinema_hall_management_system.Model;
using BL = cinema_hall_management_system.BL;

namespace cinema_hall_management_system.UI
{
    /// <summary>
    /// Interaction logic for UpdateMovie.xaml
    /// </summary>
    public partial class UpdateMovie : Window
    {
        Models.Movie movie;
        public UpdateMovie(string id)
        {
            InitializeComponent();
            initFunc(id);
        }

       

        void initFunc(string id) {

            BL.Movie movieLogic = new BL.Movie();
            
            movie= movieLogic.findMovie(id);

            txtTitle.Text = movie.title;
            txtDescription.Text = movie.description;
            txtDuration.Text = movie.duration;
            txtGenre.Text = movie.genre;
            txtDirector.Text = movie.director;
            txtRating.Text = movie.rating;
            dtRelaseDate.SelectedDate = DateTime.Parse(movie.releaseDate);

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

       

        private void btnUpdateMovie_Click(object sender, RoutedEventArgs e)
        {
             movie.title= txtTitle.Text;
             movie.description= txtDescription.Text ;
            movie.duration = txtDuration.Text ;
            movie.genre= txtGenre.Text ;
            movie.director =txtDirector.Text ;
             movie.rating= txtRating.Text;
            movie.releaseDate = dtRelaseDate.SelectedDate.ToString();

            BL.Movie movieLogic = new BL.Movie();


            try
            {
                movieLogic.updateMovie(movie.id, movie.title, movie.releaseDate, movie.description, movie.duration, movie.genre, movie.director, movie.rating);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
           
        }
    }
}
