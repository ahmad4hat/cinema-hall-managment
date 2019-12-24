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
    /// Interaction logic for AddCinemaHall.xaml
    /// </summary>
    public partial class AddCinemaHall : Window
    {
        public AddCinemaHall()
        {
            InitializeComponent();
        }

        private void BtnAddCinemaHall_Click(object sender, RoutedEventArgs e)
        {
            BL.CinemaHall logic = new BL.CinemaHall();
            try
            {
                logic.addCinemaHall(txtName.Text, txtCapacity.Text, txtLocation.Text);
            }
            catch(Exception err)
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
    }
}
