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

using System.Data;
using BookStoreLIB;

namespace BookStoreGUI
{
     public partial class EditBookDialog : Window
     {
          BookAddEdit bookAddEdit;         

          public EditBookDialog()
          {
               InitializeComponent();
          }

          // when the AddEdit dialog loads
          private void Window_Loaded(object sender, RoutedEventArgs e)
          {
               bookAddEdit = new BookAddEdit(); // Creates BookAddEdit object
          }

          private void okButton_Click(object sender, RoutedEventArgs e)
          {
               this.DialogResult = true;
          }
          private void cancelButton_Click(object sender, RoutedEventArgs e)
          {
               this.DialogResult = false;
          }
     }
}
