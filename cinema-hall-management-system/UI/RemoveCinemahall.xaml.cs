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
    /// Interaction logic for RemoveCinemahall.xaml
    /// </summary>
    public partial class RemoveCinemahall : Window
    {
        public RemoveCinemahall()
        {
            InitializeComponent();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            BL.CinemaHall cinemaHall = new BL.CinemaHall();
            try
            {
                cinemaHall.removeCinemaHall(txtId.Text);
                MessageBox.Show("succesfully deleted that cinemaHall ");
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
