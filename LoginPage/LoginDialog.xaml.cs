using BookStoreLIB;
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

namespace BookStoreGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginDialog : Window
    {
        public LoginDialog()
        {
            InitializeComponent();
        }

          private void loginButton_Click(object sender, RoutedEventArgs e)
          {
               string username = this.nameTextBox.Text;
               string password = this.passwordTextBox.Password;

               Boolean firstCheck = true;
               Boolean numberCheck = false;
               Boolean letterCheck = false;

               if (username == "" || password == "")
               {
                    MessageBox.Show("Please fill in all slots");
               }
               else
               {
                    if (username != "" && password.Length >= 6)                     // checks for length of six or more
                    {
                         if ((password[0] >= 65 && password[0] <= 90) ||            // checks for starting with a letter
                             (password[0] >= 97 && password[0] <= 122))
                         {
                              for (int i = 0; i < password.Length; i++)             // checks each character for number or letter
                              {
                                   if (password[i] >= 48 && password[i] <= 57) numberCheck = true;

                                   if ((password[i] >= 65 && password[i] <= 90) ||
                                       (password[i] >= 97 && password[i] <= 122)) letterCheck = true;
                              }
                         }
                         else
                         {
                              firstCheck = false;
                         }
                         if (firstCheck && numberCheck && letterCheck)                 // if every character is valid, print thanks
                         {
                              UserData userData = new UserData();
                              if (userData.LogIn(nameTextBox.Text, passwordTextBox.Password) != true)
                              {
                                   MessageBox.Show("You could not be verified. Please try again");
                              }
                              else
                              {
                                    //MessageBox.Show("You are now logged in as User #" + userData.UserID);
                                    MessageBox.Show("You are logged in as " + userData.FullName);
                                    this.DialogResult= true;
                              }
                         }
                    }
                    else
                    {
                         firstCheck = false;
                    }
               }

               if (!firstCheck || !letterCheck || !numberCheck)
               {
                    MessageBox.Show("A valid password needs to have at least six characters with both letters and numbers.");
               }
          }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
