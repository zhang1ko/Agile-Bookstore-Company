using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections.ObjectModel;


namespace BookStoreLIB
{

     public class BookAddEdit
     {
          DALBookAddEdit dbae = new DALBookAddEdit();
       
          public String AddBook(String ISBN, String title, String author,
               double price, int quantity, String year, String edition, 
               String publisher, int categoryID, int supplierID)
          {
               if (dbae.AddBook(ISBN, title, author, price, quantity, year,
                    edition, publisher, categoryID, supplierID) )
                    return "Successfully saved the data";
               else
                    return "Something went wrong while trying to save the data";
          }

          public String UpdateBook(string origISBN, string ISBN, string title, string author, double price, int quantity, string year, string edition, string publisher, int categoryID, int supplierID)
          {
               if (dbae.UpdateBook(origISBN, ISBN, title, author, price, quantity, year,
                    edition, publisher, categoryID, supplierID) == 1)
                    return "Successfully updated the record";
               else
                    return "Something went wrong while trying to update the record";

              
          }

          public string RemoveBook(string isbn)
          {
               if (dbae.RemoveBook(isbn) == 1)
                    return "Successfully deleted the record";
               else
                    return "Something went wrong while trying to delete the record";
          }
     }
}
