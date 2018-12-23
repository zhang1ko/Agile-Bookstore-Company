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
    /// Interaction logic for OrderHistory.xaml
    /// </summary>
    public partial class OrderHistory : Window
    {
        int userID;
        public OrderHistory(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ViewHistory viewHistory = new ViewHistory();
            
        }

        private void orderDetails_Click(object sender, RoutedEventArgs e)
        {
            ViewHistory viewHistory = new ViewHistory(); //Create View History object   
            DataRowView selectedRow;
            if (orderHistoryView.SelectedItem == null)
            {
                return;
            }
            else 
            {
                selectedRow = (DataRowView)this.orderHistoryView.SelectedItems[0];
                string OrderID = selectedRow.Row.ItemArray[0].ToString();
                int OIDnumber = Convert.ToInt32(OrderID);
                OrderDetails orderDet = new OrderDetails(); //Initiate Window
                DataSet orders = viewHistory.getDetails(OIDnumber);
                orderDet.DataContext = orders.Tables["OrderDetails"];
                orderDet.Owner = this;
                orderDet.ShowDialog();
            }
        }

    }
}
