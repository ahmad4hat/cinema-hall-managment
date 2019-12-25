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
    /// Interaction logic for MovieShowFindByIdAndUpdate.xaml
    /// </summary>
    public partial class MovieShowFindByIdAndUpdate : Window
    {
        public MovieShowFindByIdAndUpdate()
        {
            InitializeComponent();
        }

        private void TxtId_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                new BL.MovieShow().findMovieShow(txtId.Text).toString();
                new UpdateMovieShow(txtId.Text).Show();
                this.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
