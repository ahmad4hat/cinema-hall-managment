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
    /// Interaction logic for TicketUserHome.xaml
    /// </summary>
    public partial class TicketUserHome : Window
    {
        string email;
        public TicketUserHome(String email)
        {
            InitializeComponent();
            this.email = email;
            ticketList.ItemsSource = new BL.Tickets().showTicEverything("");
           
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnBuy_Click(object sender, RoutedEventArgs e)
        {
            new BuyTicket(email).Show();
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                ticketList.ItemsSource = new BL.Tickets().showTicEverything(txtSearch.Text);
            } catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            
        }
    }
}
