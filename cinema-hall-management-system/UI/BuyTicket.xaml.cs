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
    /// Interaction logic for BuyTicket.xaml
    /// </summary>
    public partial class BuyTicket : Window
    {
        String email;
        public BuyTicket(String email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void BtnAddCinemaHall_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                new DAL.DatabaseConnector().buyTicket(email, int.Parse(txtName.Text), int.Parse(txtCapacity.Text));
                MessageBox.Show("success");
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
    }
}
