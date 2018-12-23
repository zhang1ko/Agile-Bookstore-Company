using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Windows;

namespace BookStoreLIB
{

     class DALBookAddEdit
     {
          SqlConnection conn;
          DataSet dsBooks;

          public DALBookAddEdit()
          {
               conn = new SqlConnection(Properties.Settings.Default.xyConnection);
          }
          public Boolean AddBook(String ISBN, String title, String author,
              double price, int quantity, String year, String edition,
              String publisher, int categoryID, int supplierID)
          {
               Boolean result = true;

               try
               {
                    String strSQL = "INSERT INTO BookData(ISBN, CategoryID, Title, Author, " +
                         "Price, SupplierId, Year, Edition, Publisher, Quantity) " +
                         "VALUES ('" + ISBN + "', " + categoryID + ", '" + title + "', '" +
                         author + "', " + price + ", " + supplierID + ", '" + year +  "', '" + edition + "', '" + publisher + "', " + quantity + ")";

                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
               }
               catch (Exception ex)
               {
                    Debug.WriteLine(ex.Message);
                    result = false;
               }

               return result;
          }

          internal int UpdateBook(string origISBN, string ISBN, string title, string author, double price, int quantity, string year, string edition, string publisher, int categoryID, int supplierID)
          {
               int result;
               String updateISBN = origISBN; // to hold the ISBN value to be updated

               try
               {
                    String strSQL = "UPDATE BookData " +
                                    "SET" +
                                        " ISBN = '" + ISBN +
                                        "', CategoryID =" + categoryID +
                                        ", Title = '" + title +
                                        "', Author = '" + author +
                                        "', Price =" + price +
                                        ", Year = '" + year +
                                        "', Edition = '" + edition +
                                        "', Publisher = '" + publisher +
                                        "', Quantity =" + quantity +
                                     " WHERE" +
                                        " ISBN = '" + updateISBN + "'";
                    //MessageBox.Show(strSQL);
                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    conn.Open();
                    result = cmd.ExecuteNonQuery();
                    conn.Close();
               }
               catch (Exception ex)
               {
                    Debug.WriteLine(ex.Message);
                    result = -1;
               }

               return result;

          }

          internal int RemoveBook(string ISBN)
          {
               int result;

               try
               {
                    String strSQL = "DELETE BookData " +
                                     " WHERE" +
                                        " ISBN = '" + ISBN + "'";
                    //MessageBox.Show(strSQL);
                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    conn.Open();
                    result = cmd.ExecuteNonQuery();
                    conn.Close();
               }
               catch (Exception ex)
               {
                    Debug.WriteLine(ex.Message);
                    MessageBox.Show("Unable to remove book. This book has associated records in the database.", 
                         "Unable to remove book", MessageBoxButton.OK, 
                         MessageBoxImage.Error);
                    result = -1;
               }

               return result;
          }

          internal int FindBook(string ISBN)
          {
               int result;  // number of books found

               try
               {
                    String strSQL = "SELECT * FROM BookData" +
                                     " WHERE" +
                                        " ISBN = '" + ISBN + "'";
                    //MessageBox.Show(strSQL);
                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    conn.Open();
                    result = cmd.ExecuteNonQuery();
                    MessageBox.Show(result.ToString(), "SQL return");
                    conn.Close();
               }
               catch (Exception ex)
               {
                    Debug.WriteLine(ex.Message);
                    result = -1;
               }

               return result;
          }
     }
}
