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
    /// Interaction logic for EditDialog.xaml
    /// </summary>
    /// 
    public partial class EditDialog : Window
    {
        private int userID;
        public EditDialog(int UserID)
        {
            userID = UserID;            
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            string fullname = this.nameTextBox.Text;
            //string password = this.passwordTextBox.Text;
            string address = this.addressTextBox.Text;
            string postalCode = this.postalCodeTextBox.Text;
            string city = this.cityTextBox.Text;
            string province = this.provinceCodeTextBox.Text;
            string country = this.countryCodeTextBox.Text;


            if (fullname != "" && address != "")
            {
                //if (ValidatePassword(password))
                //{
                    UserData userData = new UserData();
                    userData.EditInfo(userID, fullname, address, postalCode, city, province, country);
                    this.DialogResult = true;
                //}
                //else
                    //MessageBox.Show("A valid password needs to have at least six characters with both letters and numbers.");
            }
            else
                MessageBox.Show("Please fill in all slots.");
        }
        private Boolean ValidatePassword(string passwd)
        {
            string pattern = @"^(?=.?[A-Za-z])(?=.*?[A-Za-z0-9]).{6,}$";
            Regex reg = new Regex(pattern);
            if (Regex.IsMatch(passwd, pattern))
                return true;
            else
                return false;
        }

        private void EditPassButton_Click(object sender, RoutedEventArgs e)
        {
            EditPassDialog passdlg = new EditPassDialog(userID);
            passdlg.ShowDialog();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
