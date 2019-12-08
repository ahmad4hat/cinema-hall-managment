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
    /// Interaction logic for EmployeeResgister.xaml
    /// </summary>
    public partial class EmployeeResgister : Window
    {
        public EmployeeResgister()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



        private void EmailTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void NameTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AddressTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RoleTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            String email = emailTextbox.Text;
            String address = addressTextbox.Text;
            String password = passwordBox.Password.ToString();
            String dateOfBirth = datePickerDOB.SelectedDate.ToString();
            String gender = genderSelector.Text;
            String name = nameTextbox.Text;
            String role = roleTextbox.Text;

            BL.Employee emp = new BL.Employee();
            try
            {

                emp.employeeAdd(email, password, name, address, dateOfBirth, gender, role);
                MessageBox.Show("created sucess");
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message);
            }

        }
    }
}