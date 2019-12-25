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
    /// Interaction logic for UpdateCinemaHall.xaml
    /// </summary>
    public partial class UpdateCinemaHall : Window
    {
        Model.CinemaHall cinemaHall;
        public UpdateCinemaHall(String id)
        {
            InitializeComponent();
            initFunc(id);
        }

        void initFunc(String id)
        {
            cinemaHall = new BL.CinemaHall().findCinemaHall(id);
            txtName.Text = cinemaHall.name;
            txtCapacity.Text =cinemaHall.capacity.ToString();
            txtLocation.Text = cinemaHall.location;
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                cinemaHall.name = txtName.Text;
                int cap;

                if (!int.TryParse(txtCapacity.Text, out cap))
                {
                    throw new Exception("capicity must be an number");
                }

                cinemaHall.capacity = cap;

                cinemaHall.location = txtLocation.Text;
                new BL.CinemaHall().updateCinemaHall(cinemaHall.id,cinemaHall.name,cinemaHall.capacity,cinemaHall.location);
            }catch(Exception err)
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
