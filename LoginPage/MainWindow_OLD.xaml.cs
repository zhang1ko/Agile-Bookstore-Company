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
using System.Windows.Shapes;
namespace BookStoreGUI
{
     /// Interaction logic for MainWindow.xaml
     public partial class MainWindow : Window
     {
          private void loginButton_Click(object sender, RoutedEventArgs e)
          {
               var userData = new UserData();
               var dlg = new LoginDialog();
               dlg.Owner = this;
               dlg.ShowDialog();
               // Process data entered by user if dialog box is accepted
               if (dlg.DialogResult == true)
               {
                    if (userData.LogIn(dlg.nameTextBox.Text, dlg.passwordTextBox.Password) == true)
                         this.statusTextBlock.Text = userData.FullName + ", you are logged in as User #" + userData.UserID;
          
                    else
                         MessageBox.Show("MAIN You could not be verified. Please try again.");
               }
          }
          private void exitButton_Click(object sender, RoutedEventArgs e) { this.Close(); }
          public MainWindow() { InitializeComponent(); }
          private void Window_Loaded(object sender, RoutedEventArgs e) { }
          private void addButton_Click(object sender, RoutedEventArgs e) { }
          private void chechoutButton_Click(object sender, RoutedEventArgs e) { }
     }
}
