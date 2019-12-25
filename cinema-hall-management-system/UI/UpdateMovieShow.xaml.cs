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
    /// Interaction logic for UpdateMovieShow.xaml
    /// </summary>
    public partial class UpdateMovieShow : Window
    {
        Model.MovieShow movieShow ;
        public UpdateMovieShow(String id)
        {
            InitializeComponent();
            initFunc(id);
        }

        void initFunc( String id)
        {
            movieShow = new BL.MovieShow().findMovieShow(id);

            txtMovieID.Text = movieShow.movieId.ToString();
            txtCinemHallId.Text = movieShow.cinemahallId.ToString();
            txtCapcity.Text = movieShow.remainingCapacity.ToString();
            dtTime.SelectedDate = movieShow.time;

            timeAmPmClock.Text = movieShow.time.ToString().Substring(9);



        }

        private void TxtMovieID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtCinemHallId_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TimeAmPmClock_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtCapcity_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnMovieShow_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string a = dtTime.SelectedDate.ToString();

                string b = timeAmPmClock.Text;
                if (a == "") { throw new Exception("Time and Date can't be empty"); }
                if (b == "") { throw new Exception("Time and Date can't be empty"); }
                a = a.Remove(9);

                DateTime dateTime = new DateTime();
                dateTime = DateTime.Parse(a + " " + b);


                new BL.MovieShow().updateMovieShow(movieShow.id.ToString(),txtMovieID.Text,txtCinemHallId.Text,txtCapcity.Text,dateTime);



            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
    }
}
