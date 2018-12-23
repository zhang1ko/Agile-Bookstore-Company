using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections.ObjectModel;


namespace BookStoreLIB
{

    public class BookWishlist
    {
        DALWishlist dwl = new DALWishlist();
 //       ObservableCollection<BookWishlist> bookItemList = new
 //         ObservableCollection<BookWishlist>();
        public String AddBookToWishList(String ISBN, int Uid)
        {    
            if (dwl.addBookToWishlist(ISBN, Uid))
                return "Successfully saved the data";
            else
                return "Something went wrong while trying to save the data";
        }

        public DataSet getWishListBooks(int uid)
        {
            return dwl.getWishListBooks(uid);
        }

//origin input for Removeitem: string product
        public Boolean RemoveItem(string ISBN, int Uid)
        {
            if (dwl.removeBookFromWishlist(ISBN, Uid))
            {
                return true;
            }
            else
                return false;
        }
        public DataSet getAvailableBooks(int uid)
        {
            return dwl.getAvailableBooks(uid);
        }

        public DataSet HideBooks(string ISBN, int Uid)
        {
            return dwl.hideBooks(ISBN, Uid);
        }
    }
}
