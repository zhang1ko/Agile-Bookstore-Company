using BookStoreLIB;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// <summary>
    /// Interaction logic for AvailableBooks.xaml
    /// </summary>
    /// 
    
    
    public partial class AvailableBooks : Window
    {
        int UserId;
        BookOrder bookOrder;
        Boolean removeResult = false;
        BookWishlist bookWishList = new BookWishlist();
        String selectedBooks = "";

        public AvailableBooks(int Uid, BookOrder bookOrder)
        {
            InitializeComponent();
            UserId = Uid;
            this.bookOrder = bookOrder;
        }
        

        private void addToOrder_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow;
            DataSet newBookList;

            //this.DialogResult = false;
            OrderItemDialog orderItemDialog = new OrderItemDialog();
            

            selectedRow = (DataRowView)AvailableBookView.SelectedItems[0];
            orderItemDialog.isbnTextBox.Text = selectedRow.Row.ItemArray[0].ToString();
            orderItemDialog.titleTextBox.Text = selectedRow.Row.ItemArray[1].ToString();
            orderItemDialog.priceTextBox.Text = selectedRow.Row.ItemArray[3].ToString();
            orderItemDialog.Owner = this;
            orderItemDialog.ShowDialog();

            if (orderItemDialog.DialogResult == true)
            {
                string order_isbn = orderItemDialog.isbnTextBox.Text;
                string order_title = orderItemDialog.titleTextBox.Text;
                double order_unitPrice = double.Parse(orderItemDialog.priceTextBox.Text);
                int quantity = int.Parse(orderItemDialog.quantityTextBox.Text);
                bookOrder.AddItem(new OrderItem(order_isbn, order_title, order_unitPrice, quantity));

                if(selectedBooks != "")
                {
                    selectedBooks += ",'" + order_isbn + "'";
                }else
                {
                    selectedBooks += "'" + order_isbn + "'";
                }

                newBookList = bookWishList.HideBooks(selectedBooks, UserId);
                AvailableBookView.ItemsSource = newBookList.Tables["HideBookTable"].DefaultView;
                AvailableBookView.Items.Refresh();

                /*AvailableBookView.ItemsSource = null;
                AvailableBookView.Items.Remove(selectedRow);

                removeResult = bookWishList.RemoveItem(selectedRow.Row.ItemArray[0].ToString(), UserId);
                if (removeResult)
                {
                    MessageBox.Show("Successfully Added to order and remove from wishlist", "Adding book to order",
                            MessageBoxButton.YesNo, MessageBoxImage.Question);
                    DataSet books = bookWishList.getAvailableBooks(UserId);
                    AvailableBookView.ItemsSource = books.Tables["BookTable"].DefaultView;
                    AvailableBookView.Items.Refresh();
                }
                else
                {
                    MessageBox.Show("Something went wrong while trying to delete the data", "Removing from wish list",
                            MessageBoxButton.YesNo, MessageBoxImage.Question);
                }  */
                //               DataSet books = bookWishList.HideBooks(isbn, UserId);
                //               AvailableBookView.ItemsSource = books.Tables["HideBookTable"].DefaultView;
                //               AvailableBookView.Items.Refresh();

            }          
        }
    }
}
