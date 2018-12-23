using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace BookStoreLIB
{
    class DALViewHistory
    {
        SqlConnection conn;
        DataSet dsOrders;
        DataSet dsDetails;

        public DALViewHistory()
        {
            conn = new SqlConnection(Properties.Settings.Default.xyConnection);
        }
        public DataSet getOrders(int Uid)
        {
            int rows;

            try
            {
                String sqlStn = "Select OrderID, OrderDate, Status, Price from Orders " +
                                "where UserID = " + Uid;
                //SqlCommand cmd = new SqlCommand(sqlStn);
                SqlDataAdapter daWOrder = new SqlDataAdapter(sqlStn, conn);
                dsOrders = new DataSet("ViewOrderHistory");
                rows = daWOrder.Fill(dsOrders, "UserOrders");

            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }

            return dsOrders;
        }

        public DataSet getDetails(int Oid)
        {
            int rows;

            try
            {
                String sqlStn = "Select o.ISBN, o.Quantity, b.Title, b.Author, b.Price, b.Year from OrderItem as o INNER JOIN " +
                "BookData as b ON o.ISBN = b.ISBN where o.OrderID = " + Oid;
                SqlDataAdapter daWOrder = new SqlDataAdapter(sqlStn, conn);
                dsDetails = new DataSet("ViewOrderDetails");
                rows = daWOrder.Fill(dsDetails, "OrderDetails");

            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }

            return dsDetails;
        }
    }
}
