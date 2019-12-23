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
using BL= cinema_hall_management_system.BL ;

namespace cinema_hall_management_system.UI
{
    /// <summary>
    /// Interaction logic for RemoveMovie.xaml
    /// </summary>
    public partial class RemoveMovie : Window
    {
        public RemoveMovie()
        {
            InitializeComponent();
        }

        private void TxtId_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            BL.Movie movie = new BL.Movie();
            try
            {
                movie.removeMovie(txtId.Text);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }
    }
}
