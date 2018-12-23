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
     /// <summary>
     /// Interaction logic for AdministrationWindow.xaml
     /// </summary>
     public partial class AdministrationWindow : Window
     {
          DataSet dsBookCat;
          DataTable dbtable;
          UserData userData;
          BookOrder bookOrder;
          BookAddEdit bookAddEdit;

          //int globalUserID = 0;

          public AdministrationWindow()
          {
               //this.dbtable = dbtable;
               InitializeComponent();
          }

          private void Window_Loaded_1(object sender, RoutedEventArgs e)
          {
               BookCatalog bookCat = new BookCatalog();
               dsBookCat = bookCat.GetAllBookInfo();
               this.DataContext = dsBookCat.Tables["Category"];

               bookAddEdit = new BookAddEdit(); // Creates BookAddEdit object


               //this.DataContext = dsBookCat.Tables["Category"];
               //bookOrder = new BookOrder();
               //userData = new UserData();
               //this.orderListView.ItemsSource = bookOrder.OrderItemList;
          }

          internal void UpdateData()
          {
               BookCatalog bookCat = new BookCatalog();
               dsBookCat = bookCat.GetAllBookInfo();
               this.DataContext = dsBookCat.Tables["Category"];
          }

          private void ProductsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
          {

          }

          private void editButton_Click(object sender, RoutedEventArgs e)
          {
               EditBookDialog editBookDialog = new EditBookDialog(); //Initiate Window
               DataRowView selectedRow;
               selectedRow = (DataRowView)this.ProductsDataGrid.SelectedItems[0];
               String result;
               String origISBN;

               editBookDialog.isbnTextBox.Text = selectedRow.Row.ItemArray[0].ToString();
               editBookDialog.titleTextBox.Text = selectedRow.Row.ItemArray[2].ToString();
               editBookDialog.authorTextBox.Text = selectedRow.Row.ItemArray[3].ToString();
               editBookDialog.priceTextBox.Text = selectedRow.Row.ItemArray[4].ToString();
               editBookDialog.quantityTextBox.Text = selectedRow.Row.ItemArray[8].ToString();
               editBookDialog.yearTextBox.Text = selectedRow.Row.ItemArray[5].ToString();
               editBookDialog.editionTextBox.Text = selectedRow.Row.ItemArray[6].ToString();
               editBookDialog.publisherTextBox.Text = selectedRow.Row.ItemArray[7].ToString();
               editBookDialog.categoryTextBox.Text = selectedRow.Row.ItemArray[9].ToString();
               editBookDialog.supplierTextBox.Text = selectedRow.Row.ItemArray[10].ToString();

               origISBN = selectedRow.Row.ItemArray[0].ToString();
               editBookDialog.okButton.Content = "Update Book";               
               editBookDialog.Owner = this;
               
               editBookDialog.ShowDialog();

               if (editBookDialog.DialogResult == true)
               {
                    string isbn = editBookDialog.isbnTextBox.Text;
                    string title = editBookDialog.titleTextBox.Text;
                    string author = editBookDialog.authorTextBox.Text;
                    double price = double.Parse(editBookDialog.priceTextBox.Text);
                    int quantity = int.Parse(editBookDialog.quantityTextBox.Text);
                    string year = editBookDialog.yearTextBox.Text;
                    string edition = editBookDialog.editionTextBox.Text;
                    string publisher = editBookDialog.publisherTextBox.Text;
                    int categoryID = int.Parse(editBookDialog.categoryTextBox.Text);
                    int supplierID = int.Parse(editBookDialog.supplierTextBox.Text);

                    result = bookAddEdit.UpdateBook(origISBN, isbn, title, author, price, quantity, year, edition, publisher, categoryID, supplierID);
                    this.UpdateData(); // updates the DataGrid
                    MessageBox.Show(result);
               }
          }

          private void addButton_Click(object sender, RoutedEventArgs e)
          {
               EditBookDialog editBookDialog = new EditBookDialog(); //Initiate Window
               String result;

               editBookDialog.ShowDialog();

               if (editBookDialog.DialogResult == true)
               {
                    try
                    {
                         string isbn = editBookDialog.isbnTextBox.Text;
                         string title = editBookDialog.titleTextBox.Text;
                         string author = editBookDialog.authorTextBox.Text;
                         double price = double.Parse(editBookDialog.priceTextBox.Text);
                         int quantity = int.Parse(editBookDialog.quantityTextBox.Text);
                         string year = editBookDialog.yearTextBox.Text;
                         string edition = editBookDialog.editionTextBox.Text;
                         string publisher = editBookDialog.publisherTextBox.Text;
                         int categoryID = int.Parse(editBookDialog.categoryTextBox.Text);
                         int supplierID = int.Parse(editBookDialog.supplierTextBox.Text);

                         result = bookAddEdit.AddBook(isbn, title, author, price, quantity, year, edition, publisher, categoryID, supplierID);
                         this.UpdateData();
                         MessageBox.Show(result);
                    }
                    catch (Exception)
                    {
                         MessageBox.Show("All fields must be filled out in the correct data format");
                         //throw;
                    }

                    

                    
               }

          }

          private void removeButton_Click(object sender, RoutedEventArgs e)
          {
               DataRowView selectedRow;
               try
               {
                    selectedRow = (DataRowView)this.ProductsDataGrid.SelectedItems[0];
               }
               catch (Exception)
               {
                    return;
               }
               

               string isbn = selectedRow.Row.ItemArray[0].ToString();
               string title = selectedRow.Row.ItemArray[2].ToString();
               String result;

               MessageBoxResult messageBoxResult = MessageBox.Show("Are you " +
                    "sure " + "you want to delete '" + title + "' (" + isbn + ")?", 
                    "Delete '" + title +"'", MessageBoxButton.YesNo, 
                    MessageBoxImage.Warning, 
                    MessageBoxResult.No );

               String mbr = messageBoxResult.ToString();

               if (mbr.Equals("Yes") )
               {
                    //MessageBox.Show("Ready to delete");
                    result = bookAddEdit.RemoveBook(isbn);
               }


          }
     }
}
