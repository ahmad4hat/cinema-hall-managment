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
using System.Windows.Navigation;
using System.Windows.Shapes;
using cinema_hall_management_system.UI;
using cinema_hall_management_system.DAL;
using Models= cinema_hall_management_system.Model;

namespace cinema_hall_management_system
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Models.Employee e = new Models.Employee();
            e.name = "base";
        }

     

        private void UserButton_Click(object sender, RoutedEventArgs e)
        {
            UserLogin user = new UserLogin();
            user.Show();
            Close();

        }

        private void EmployeeButton_Click_1(object sender, RoutedEventArgs e)
        {
            EmployeeLogin employee = new EmployeeLogin();
            employee.Show();
            Close();
         //   cinema_hall_management_system.UI.EmployeeLogin emp = new cinema_hall_management_system.UI.EmployeeLogin();


        }
    }
}
