using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace BookStoreLIB
{
    class DALOrderHistory
    {
        SqlConnection conn;
        DataSet dsBooks2;
        DataSet dsBooks;
        public DALOrderHistory()
        {
            conn = new SqlConnection(Properties.Settings.Default.tfsConnection);
        }

        public DataSet GetOrderInfo()
        {
            try
            {
                String strSQL3 = "Select CategoryID, Name, Description from Category";
                SqlCommand cmdSelCategory2 = new SqlCommand(strSQL3, conn);
                SqlDataAdapter daCatagory2 = new SqlDataAdapter(cmdSelCategory2);
                dsBooks2 = new DataSet("Orders");
                daCatagory2.Fill(dsBooks2, "Category");            //Get category info
                String strSQL4 = "Select * from Orders";
                SqlCommand cmdSelBook2 = new SqlCommand(strSQL4, conn);
                SqlDataAdapter daBook2 = new SqlDataAdapter(cmdSelBook2);
                daBook2.Fill(dsBooks2, "Orders");                  //Get Books info
                DataRelation drOrder = new DataRelation("drOrder",
                dsBooks2.Tables["Category"].Columns["OrderID"],
                dsBooks2.Tables["Orders"].Columns["OrderID"], false);
                dsBooks2.Relations.Add(drOrder);       //Set up the table relation


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return dsBooks2;
        }
    }
}
