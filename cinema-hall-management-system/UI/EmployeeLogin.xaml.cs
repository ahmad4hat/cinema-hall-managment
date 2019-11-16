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
using cinema_hall_management_system.DAL;


namespace cinema_hall_management_system.UI
{
    /// <summary>
    /// Interaction logic for EmployeeLogin.xaml
    /// </summary>
    public partial class EmployeeLogin : Window
    {
        public EmployeeLogin()
        {
            InitializeComponent();
        }

        private void LoginButtonClicked_Click(object sender, RoutedEventArgs e)
        {
            String b = passwordPasswordBox.Password.ToString();
            Console.WriteLine(emailTextBox.Text, passwordPasswordBox.Password.ToString());
            DatabaseConnector dal = new DatabaseConnector();
            if (dal.empLoginTest(emailTextBox.Text, b))
            {
                MessageBox.Show("Login successful");
            }
            else
            {
                MessageBox.Show("email or password is not correct");
            };
         
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeeResgister empRes = new EmployeeResgister();
            empRes.Show();
        }
    }
}
