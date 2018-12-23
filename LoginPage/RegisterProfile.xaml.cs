using BookStoreLIB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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


namespace BookStoreGUI
{
    /// <summary>
    /// Interaction logic for RegisterProfile.xaml
    /// </summary>
    public partial class RegisterProfile : Window
    {
        public RegisterProfile()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            string username = this.unameTextBox.Text;
            string fullname = this.fullnameTextBox.Text;
            string password = this.passwordTextBox.Text;
            string address = this.addressTextBox.Text;
            string postalCode = this.postalCodeTextBox.Text;
            string city = this.cityTextBox.Text;
            string province = this.provinceCodeTextBox.Text;
            string country = this.countryCodeTextBox.Text;


            if (username != "" && password != "" && fullname != "" && address != "" && postalCode != "" && city != "" && province != "" && country != "")
            {
                if (ValidateUsername(username) && ValidatePassword(password))
                {
                    UserData userData = new UserData();
                    userData.CreateProfile(username, password, fullname, address, postalCode, city, province, country);
                    MessageBox.Show("Welcome " + userData.FullName);
                    this.DialogResult = true;
                }
            }
            else
                MessageBox.Show("Please fill in all slots.");
        }

        private Boolean ValidatePassword(String passwd)
        {
            string pattern = @"^(?=.?[A-Za-z])(?=.*?[A-Za-z0-9]).{6,}$";
            Regex reg = new Regex(pattern);
            if (Regex.IsMatch(passwd, pattern))
                return true;
            else
            {
                MessageBox.Show("A valid password needs to have at least six characters with both letters and numbers.");
                return false;
            }
        }

        private Boolean ValidateUsername(String username)
        {
            UserData userData = new UserData();
            if (userData.checkUserName(username))
                return true;
            else
            {
                MessageBox.Show("Username " + username + " already exists.");
                return false;
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
