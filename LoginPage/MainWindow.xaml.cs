/* **********************************************************************************
 * For use by students taking 60-422 (Fall, 2014) to work on assignments and project.
 * Permission required material. Contact: xyuan@uwindsor.ca 
 * **********************************************************************************/
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
using System.Collections;
using System.Collections.ObjectModel;


namespace BookStoreGUI
{
     /// Interaction logic for MainWindow.xaml
     public partial class MainWindow : Window
     {
          DataSet dsBookCat;
          DataTable dbtable;
          UserData userData;
          BookOrder bookOrder;
          Wishlist wishlist;
          BookWishlist bookWishList;
        AvailableBooks availableBooks;
        OrderHistory orderDialog;
        ViewHistory viewHistory;
        //Global Variable used for keeping track of User Session.
        private int globalUserID = 0;
        private double globalTotal = 0;

          //public DataTable Dbtable { get => dbtable; set => dbtable = value; }

          private void loginButton_Click(object sender, RoutedEventArgs e)
          {
            if (globalUserID == 0)
            {
                LoginDialog dlg = new LoginDialog();
                dlg.Owner = this;
                dlg.ShowDialog();
                // Process data entered by user if dialog box is accepted
                if (dlg.DialogResult == true)
                {
                    if (userData.LogIn(dlg.nameTextBox.Text, dlg.passwordTextBox.Password) == true)
                    {
                        userData.LogoutCheck(false);
                        this.statusTextBlock.Text = "You are logged in as " + userData.FullName;
                       
                        bookWishList = new BookWishlist(); //Create Wishlist object   
                        viewHistory = new ViewHistory(); //Create View History object   

                        CheckAvailableBook();
                        if (userData.isManager) //Checks if Account is Manager
                        {
                            this.adminButton.Visibility = Visibility.Visible;
                            this.wishListButton.Visibility = Visibility.Visible;
                            this.orderHistoryButton.Visibility = Visibility.Visible;
                            this.editProfile.Visibility = Visibility.Visible;

                        }
                        else
                        {
                            this.adminButton.Visibility = Visibility.Hidden; // hide admin button
                            this.wishListButton.Visibility = Visibility.Visible; //Display wishlist for non admin
                            this.orderHistoryButton.Visibility = Visibility.Visible;
                            this.editProfile.Visibility = Visibility.Visible;

                        }

                        //Hide Login Text on Login Button
                        this.loginButton.Content = "Logout";
                        globalUserID = userData.UserID;
                    }
                    else //if Login Fails
                        this.statusTextBlock.Text = "Your login failed. Please try again.";
                }
            }
            else //If user is already logged in and wants to logout
            {
                userData.LogoutCheck(true);
                globalUserID = 0;
                this.loginButton.Content = "Login";
                this.statusTextBlock.Text = "You have successfully Logged Out!";
                this.adminButton.Visibility = Visibility.Hidden; //Hide Admin Button
                this.wishListButton.Visibility = Visibility.Hidden; //Hide Wishlist Button
                this.orderHistoryButton.Visibility = Visibility.Hidden;
                this.editProfile.Visibility = Visibility.Hidden;
            }
        }

          private void editprofile_Click(object sender, RoutedEventArgs e) //Edit Profile Button
          {
            //Variable to save textbox values
            String userFullName;
            String userAddress;
            String userPostalCode;
            String userCity;
            String userCountry;
            String userProvince;

            EditDialog editdlg = new EditDialog(globalUserID); //Uses GlobalUserID to get access to user information
            UserData currentData = new UserData();
            Boolean getData = currentData.GetInfo(globalUserID); //Getting user data
            editdlg.Owner = this;

            //Saving Data from SQL
            userFullName = currentData.FullName;
            userAddress = currentData.Address;
            userPostalCode = currentData.PostalCode;
            userProvince = currentData.Province;
            userCity = currentData.City;
            userCountry = currentData.Country;

            //Setting  Textbox Text as Variables
            editdlg.addressTextBox.Text = userAddress;
            editdlg.nameTextBox.Text = userFullName;
            editdlg.postalCodeTextBox.Text = userPostalCode;
            editdlg.provinceCodeTextBox.Text = userProvince;
            editdlg.cityTextBox.Text = userCity;
            editdlg.countryCodeTextBox.Text = userCountry;

            //Checks to show Edit Dialog
            if (globalUserID > 0)
               {
                    editdlg.ShowDialog();
               }
               else
                    this.statusTextBlock.Text = "Log In Before Editting Profile";
          }

            //Function for Registration Button Click
          private void register_Click(object sender, RoutedEventArgs e) //Register Button
          {
               RegisterProfile regdlg = new RegisterProfile();
               regdlg.Owner = this;
               regdlg.ShowDialog();

               if (userData.LogIn(regdlg.unameTextBox.Text, regdlg.passwordTextBox.Text) == true)
               {
                    globalUserID = userData.UserID;
                    this.statusTextBlock.Text = "You are logged in as " +
                    userData.FullName;
               }
               else
                    this.statusTextBlock.Text = "Your login failed. Please try again.";
          }

        //Exit button click function
          private void exitButton_Click(object sender, RoutedEventArgs e) { this.Close(); }

        //Main Window Initialization Window
          public MainWindow() { InitializeComponent(); }

        //After initialization loading books
          private void Window_Loaded(object sender, RoutedEventArgs e)
          {
               BookCatalog bookCat = new BookCatalog();
               dsBookCat = bookCat.GetBookInfo();
               this.DataContext = dsBookCat.Tables["Category"];
               bookOrder = new BookOrder();
               userData = new UserData();
               this.orderListView.ItemsSource = bookOrder.OrderItemList;
            searchComboBox.SelectedIndex = 0;
          }

        //Add Books button Click
          private void addButton_Click(object sender, RoutedEventArgs e)
          {
               int bookQuantity;
               String addToWLResult = "";

               OrderItemDialog orderItemDialog = new OrderItemDialog(); //Initiate Window
               DataRowView selectedRow;
               selectedRow = (DataRowView)this.ProductsDataGrid.SelectedItems[0];
               //this.totalTextBox.Text = bookOrder.GetOrderTotal().ToString();

            bookQuantity = int.Parse(selectedRow.Row.ItemArray[8].ToString());

               if (bookQuantity < 1)
               {

                    WishlistDialog result = new WishlistDialog();
                    result.Owner = this;
                    result.ShowDialog();
                    if (result.DialogResult == true)
                    {
                         //Need to add username here !!!!
                         addToWLResult = bookWishList.AddBookToWishList(selectedRow.Row.ItemArray[0].ToString(),
                                                                         userData.UserID);

                         MessageBox.Show(addToWLResult, "Adding to wish list",
                             MessageBoxButton.YesNo, MessageBoxImage.Question);
                    }
               }
               else
               {
                    orderItemDialog.isbnTextBox.Text = selectedRow.Row.ItemArray[0].ToString();
                    orderItemDialog.titleTextBox.Text = selectedRow.Row.ItemArray[2].ToString();
                    orderItemDialog.priceTextBox.Text = selectedRow.Row.ItemArray[4].ToString();
                    orderItemDialog.Owner = this;
                    orderItemDialog.ShowDialog();
                    if (orderItemDialog.DialogResult == true)
                    {
                         string isbn = orderItemDialog.isbnTextBox.Text;
                         string title = orderItemDialog.titleTextBox.Text;
                         double unitPrice = double.Parse(orderItemDialog.priceTextBox.Text);
                         int quantity = int.Parse(orderItemDialog.quantityTextBox.Text);
                         double price = unitPrice * quantity;
                         bookOrder.AddItem(new OrderItem(isbn, title, unitPrice, quantity));
                         globalTotal += price;
                         this.totalTextBox.Text = globalTotal.ToString();

                    }
               }

          }

        //Remove Book Button Click
          private void removeButton_Click(object sender, RoutedEventArgs e)
          {
               if (this.orderListView.SelectedItem != null)
               {
                    var selectedOrderItem = this.orderListView.SelectedItem as OrderItem;
                    bookOrder.RemoveItem(selectedOrderItem.BookID);
                    globalTotal = globalTotal - selectedOrderItem.SubTotal;
                    this.totalTextBox.Text = globalTotal.ToString();

            }
        }

        //Checkout Button Click
          private void chechoutButton_Click(object sender, RoutedEventArgs e)
          {
                ArrayList orderedBooks = new ArrayList();   //Added by Johan for Wishlist clearance
                int orderId;
                if (globalUserID > 0)
                {
                    orderId = bookOrder.PlaceOrder(userData.UserID, bookOrder.GetOrderTotal());
                    MessageBox.Show("Your order has been placed. Your order id is " +
                    orderId.ToString() + " and Total is " + bookOrder.GetOrderTotal());

                    //Code added by Johan to deleate books from wishlist if they exists
                    orderedBooks = bookOrder.getOrderISBNList();
                    foreach(var bookISBN in orderedBooks)
                    {
                        bookWishList.RemoveItem(bookISBN.ToString(), userData.UserID);
                        bookOrder.RemoveItem(bookISBN.ToString());  //Remove the books from the order
                    }

                    orderListView.ItemsSource = bookOrder.OrderItemList;
                    //Wishlist development completed

                //Recommendations recommend = new Recommendations(userData.UserID);
                //recommend.ShowDialog();
            }
                else
                    this.statusTextBlock.Text = "Log In Before Placing an Order";
        }

        //Opens preview book dialog window with page pictures
          private void previewButton_Click(object sender, RoutedEventArgs e)
          {
               String ISBN;
               int number;
               int imageID;
               String bookName;
               String imageName;
               String imageSource;
               char[] charstoTrim = { ' ' };

               PreviewWindow previewWindow = new PreviewWindow();
               DataRowView selectedRow;
               selectedRow = (DataRowView)this.ProductsDataGrid.SelectedItems[0];
               ISBN = selectedRow.Row.ItemArray[0].ToString();
               bookName = selectedRow.Row.ItemArray[2].ToString();
               number = Convert.ToInt32(ISBN);


            //Setting the image for the dialog window
               imageViewer img = new imageViewer();
               if (img.imgSeeker(number) == true)
               {
                    imageID = img.imageID;
                    imageName = img.imageName;
               }

               previewWindow.isbnTextBox.Text = ISBN;
               previewWindow.nameTextBox.Text = bookName;


               imageSource = img.imageName.Trim(charstoTrim);

               BitmapImage image = new BitmapImage(new Uri("/BookStoreGUI;component/assets/" + imageSource + ".jpg", UriKind.Relative));
               previewWindow.image.Source = image;
               previewWindow.ShowDialog();
          }

        //Search button Click
          private void searchButton_Click(object sender, RoutedEventArgs e)
          {
            this.perform_search();
         }

        //Search Combo Box
          private void searchComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
          {
               textBox1.Text = "";
               this.perform_search();
          }

        //Search Perform Function
          private void perform_search()
          {
               if (categoriesComboBox.SelectedIndex < 0)
               {
                    return;
               }

               if ((ProductsDataGrid.ItemsSource == null) || !(ProductsDataGrid.ItemsSource is DataView))
               {
                    return;
               }

               //Setting up data Grid
               DataView dv = (ProductsDataGrid.ItemsSource as DataView);
               if (textBox1.Text.Trim().Length == 0)
               {
                    dv.RowFilter = "";
                    return;
               }

               switch (searchComboBox.SelectedIndex)
               {
                    case 0:
                         {
                              dv.RowFilter = string.Format("Title LIKE '{0}%' OR Title LIKE '% {0}%'", textBox1.Text);
                              break;
                         }
                    case 1:
                         {
                              dv.RowFilter = string.Format("Author LIKE '{0}%' OR Author LIKE '% {0}%'", textBox1.Text);
                              break;
                         }
                    case 2:
                         {
                              dv.RowFilter = string.Format("CONVERT(Price, System.String) LIKE '{0}%'", textBox1.Text);
                              break;
                         }
                    case 3:
                         {
                              dv.RowFilter = string.Format("CONVERT(Year, System.String) LIKE '{0}%'", textBox1.Text);
                              break;
                         }
                    default:
                         {
                              dv.RowFilter = "";
                              break;
                         }
               }
          }

        //Function for search box?
          private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
          {
               this.perform_search();
          }

        //Categories for searchbox
          private void categoriesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
          {
               textBox1.Text = "";
               this.perform_search();
          }

        //Setting a global ID for User
          public int getSessionID()
          {
               return globalUserID;
          }

        //BitmapImage
          private void BitmapImage()
          {
               throw new NotImplementedException();
          }

        //Administrator Button Click Function
          private void AdminButton_Click(object sender, RoutedEventArgs e)
          {
               // Code to open an administation window
               AdministrationWindow window = new AdministrationWindow();
               window.Owner = this;
               window.ShowDialog();
          }

          private void orderHistory_Click(object sender, RoutedEventArgs e)
          {
               orderDialog = new OrderHistory(userData.UserID);
               DataSet orders = viewHistory.getOrders(userData.UserID);
               orderDialog.Owner = this;
               orderDialog.DataContext = orders.Tables["UserOrders"];
               orderDialog.ShowDialog();
          }

          private void wishlistButton_Click(object sender, RoutedEventArgs e)
          {
               wishlist = new Wishlist(userData.UserID,bookOrder);
               DataSet books = bookWishList.getWishListBooks(userData.UserID);
               //int rows = books.Tables["UsersBooks"].Rows.Count;
               wishlist.Owner = this;
               wishlist.DataContext = books.Tables["UsersBooks"];
               wishlist.ShowDialog();
               //WishListPage wlp = new WishListPage();
               //this.Content = wlp;
          }

        //Checking if the book is available or not

          private void CheckAvailableBook()
          {
                int count;
                availableBooks = new AvailableBooks(userData.UserID, bookOrder);
                DataSet books = bookWishList.getAvailableBooks(userData.UserID);
                availableBooks.Owner = this;
                availableBooks.DataContext = books.Tables["BookTable"];
                count = books.Tables["BookTable"].Rows.Count;
                if (count > 0)
                {
                    availableBooks.ShowDialog();
                }    
          }
     }

}
