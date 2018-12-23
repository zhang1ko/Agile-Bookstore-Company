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

    class DALWishlist
    {
        SqlConnection conn;
        DataSet dsBooks;

        public DALWishlist()
        {
            conn = new SqlConnection(Properties.Settings.Default.xyConnection);
        }
        public Boolean addBookToWishlist(String ISBN, int Uid)
        {
            Boolean result = true;

            try
            {
                String strSQL = "Insert into WishList Values (" + Uid + ", '"  + ISBN + "')";
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
                result = false;
            }

            return result;
        }

        public Boolean removeBookFromWishlist(String ISBN, int Uid)
        {

            Boolean result = false;

            try
            {
                String strSQL = "DELETE FROM WishList WHERE Userid =" + Uid + "AND ISBN =" + ISBN;
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                result = true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                result = false;
            }

            return result;
        }

        public DataSet getWishListBooks(int Uid)
        {
            int rows;

            try
            {
                String sqlStn = "Select b.ISBN, b.Title, b.Author, b.Price, b.Year from BookData as b INNER JOIN " +
                                "WishList as w ON b.ISBN = w.ISBN where w.userid = " + Uid;
                //SqlCommand cmd = new SqlCommand(sqlStn);
                SqlDataAdapter daWBook = new SqlDataAdapter(sqlStn, conn);
                dsBooks = new DataSet("WishListBooks");
                rows = daWBook.Fill(dsBooks, "UsersBooks");
                
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }

            return dsBooks;
        }

        public DataSet getAvailableBooks(int Uid){
            int rows;
            try
            {
                String sqlStn = "Select b.ISBN, b.Title, b.Author, b.Price, b.Year from BookData as b INNER JOIN " +
                                "WishList as w ON b.ISBN = w.ISBN where w.userid = " + Uid + "and b.Quantity > 0";
                SqlDataAdapter daWBook = new SqlDataAdapter(sqlStn, conn);
                dsBooks = new DataSet("QBooks");
                rows = daWBook.Fill(dsBooks, "BookTable");
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return dsBooks;
        }

        public DataSet hideBooks(String ISBN,int Uid)
        {
            int rows;
            try
            {
                String sqlStn = "Select b.ISBN, b.Title, b.Author, b.Price, b.Year from BookData as b INNER JOIN " +
                                "WishList as w ON b.ISBN = w.ISBN where w.userid = " + Uid + "and b.Quantity > 0 " +                                                                
                                "and b.ISBN NOT IN (" + ISBN + ");";
                SqlDataAdapter dawBook = new SqlDataAdapter(sqlStn, conn);
                dsBooks = new DataSet("QBooks");
                rows = dawBook.Fill(dsBooks, "HideBookTable");
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return dsBooks;
        }
    }    
}
