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
    /// Interaction logic for CinemaHalls.xaml
    /// </summary>
    public partial class CinemaHalls : Window
    {
        BL.CinemaHall Logic = new BL.CinemaHall();
        public CinemaHalls()
        {
            InitializeComponent();
            cinemaHallList.ItemsSource = Logic.getCinemaHalls();
        }
    }
}
