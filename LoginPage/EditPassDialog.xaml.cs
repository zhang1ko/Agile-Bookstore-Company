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
using System.Text.RegularExpressions;
using BookStoreLIB;

namespace BookStoreGUI
{
    /// <summary>
    /// Interaction logic for EditPassDialog.xaml
    /// </summary>
    public partial class EditPassDialog : Window
    {
        int userID;
        public EditPassDialog(int UserID)
        {
            userID = UserID;
            InitializeComponent();
        }

        private void cancelButtonClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void submitButtonClick(object sender, RoutedEventArgs e)
        {
            UserData currentPass = new UserData();
            Boolean getPass = currentPass.GetPass(userID);
            if(getPass == true)
            {
                if(currentPass.userPassword == this.oldPassTextBox.Text)
                {
                    if (ValidatePassword(this.newPassTextBox.Text))
                    {
                        Boolean setPass = currentPass.SetPass(this.newPassTextBox.Text, userID);
                        if (setPass == true)
                        {
                            MessageBox.Show("New Password Set");
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect New Password Format.");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Old Password.");
                }

            }
            
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
    }
}
