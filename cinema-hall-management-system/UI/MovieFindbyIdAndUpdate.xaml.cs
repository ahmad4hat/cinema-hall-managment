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
    /// Interaction logic for MovieFindbyIdAndUpdate.xaml
    /// </summary>
    public partial class MovieFindbyIdAndUpdate : Window
    {
        public MovieFindbyIdAndUpdate()
        {
            InitializeComponent();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BL.Movie movieLogic = new BL.Movie();
                Model.Movie movie = movieLogic.findMovie(txtId.Text);
                UpdateMovie um = new UpdateMovie(txtId.Text);
                um.Show();
                this.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void TxtId_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
