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
    /// Interaction logic for Wishlist.xaml
    /// </summary>
    public partial class Wishlist : Window
    {
        BookWishlist bookWishList = new BookWishlist();
        Boolean removeResult = false;
        BookOrder bookOrder;
        String removeFromWLResult = "";
        int UserId;
        String selectedBooks = "";
        Wishlist wishlist;
        
        public Wishlist(int Uid, BookOrder bookOrder)
        {
            InitializeComponent();
            UserId = Uid;
            this.bookOrder = bookOrder;
        }
        /*
                private void ok_Click(object sender, RoutedEventArgs e)
                {
                    this.DialogResult = true;
                }
        */

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow;
            DataSet newBookList;

            //this.DialogResult = false;
            OrderItemDialog orderItemDialog = new OrderItemDialog();

            selectedRow = (DataRowView)wishListView.SelectedItems[0];
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

                if (selectedBooks != "")
                {
                    selectedBooks += ",'" + order_isbn + "'";
                }
                else
                {
                    selectedBooks += "'" + order_isbn + "'";
                }

                newBookList = bookWishList.HideBooks(selectedBooks, UserId);
                wishListView.ItemsSource = newBookList.Tables["HideBookTable"].DefaultView;
                wishListView.Items.Refresh();
            }

        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow;
            wishListView.CanUserDeleteRows = true;
            if (wishListView.SelectedItem == null)
            {
                return;
            }
            selectedRow = (DataRowView)wishListView.SelectedItems[0];
            wishListView.ItemsSource = null;
            removeResult = bookWishList.RemoveItem(selectedRow.Row.ItemArray[0].ToString(),UserId);

            if (removeResult)
            {
                MessageBox.Show("Successfully remove the data", "Removing from wish list",
                        MessageBoxButton.YesNo, MessageBoxImage.Question);
                DataSet books = bookWishList.getWishListBooks(UserId);
                wishListView.ItemsSource = books.Tables["UsersBooks"].DefaultView;
                wishListView.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Something went wrong while trying to delete the data", "Removing from wish list",
                        MessageBoxButton.YesNo, MessageBoxImage.Question);
            }
            //wishListView.Items.Remove(selectedRow);
        }
    }
}
