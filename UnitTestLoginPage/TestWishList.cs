using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace BookStoreLIB
{
    [TestClass]
    public class TestWishList
    {
        BookWishlist bw = new BookWishlist();
        int uid;
        String isbn;
        DataSet books;
        DataTable wishListBooks;
        BookOrder bookOrder;
        DataTable orderBooks;

        [TestMethod]//Test GetWbooks methods check the getWishListBooks method
        public void TestGetWBooks1(){
            uid = 4;
            int expectedCount = 2;
            books = bw.getWishListBooks(uid);
            wishListBooks = books.Tables["UsersBooks"];
            Assert.AreEqual(expectedCount, wishListBooks.Rows.Count);
        }

        [TestMethod]
        public void TestGetWBooks2(){
            uid = 11;
            int expectedCount = 0;
            books = bw.getWishListBooks(uid);
            wishListBooks = books.Tables["UsersBooks"];
            Assert.AreEqual(expectedCount, wishListBooks.Rows.Count);
        }

        [TestMethod]
        public void TestGetWBooks3()
        {
            uid = 5;
            int expectedCount = 1;
            books = bw.getWishListBooks(uid);
            wishListBooks = books.Tables["UsersBooks"];
            Assert.AreEqual(expectedCount, wishListBooks.Rows.Count);
        }

        [TestMethod]
        public void TestGetWBooks4()
        {
            uid = 8;
            int expectedCount = 2;
            books = bw.getWishListBooks(uid);
            wishListBooks = books.Tables["UsersBooks"];
            Assert.AreEqual(expectedCount, wishListBooks.Rows.Count);
        }

        [TestMethod]//Try to add and then remove the same book from a user's wishlist
        public void TestAddReomveBookWishlist1()
        {
            uid = 8;
            String ISBN = "161729134";
            String expectedAddReturn = "Successfully saved the data";
            Boolean expectedRemoveReturn = true;
            String actualAddReturn ="";
            Boolean actualRemoveReturn;
            actualAddReturn = bw.AddBookToWishList(ISBN,uid);
            Assert.AreEqual(expectedAddReturn, actualAddReturn);
            actualRemoveReturn = bw.RemoveItem(ISBN, uid);
            Assert.AreEqual(expectedRemoveReturn, actualRemoveReturn);
        }

       

        [TestMethod]//Check the getAvailableBooks method 
        public void TestCheckABooks1(){
            uid = 4;
            int expectedCount = 2;
            books = bw.getAvailableBooks(uid);
            wishListBooks = books.Tables["BookTable"];
            Assert.AreEqual(expectedCount, wishListBooks.Rows.Count);
        }

        [TestMethod]//Add the book to order from available book window and check if the number of book in order equal to our expected value
        public void TestAddToOrder1()
        {
            uid = 9;
            String order_isbn = "161729134";
            String order_title = "NULLC## in Depth";
            double order_unitPrice = 41.22;
            int quantity = 2;
            int expectedCount = 1;
            bookOrder = new BookOrder();
            bookOrder.AddItem(new OrderItem(order_isbn, order_title, order_unitPrice, quantity));
            Assert.AreEqual(expectedCount, bookOrder.OrderItemList.Count);

        }

        [TestMethod]//Hide the book when user add the book to order in the available book window
        public void TestHideBooks1()
        {
            uid = 9;
            String ISBN = "161729134";
            int expectedCount = 1;
            books = bw.HideBooks(ISBN, uid);
            wishListBooks = books.Tables["HideBookTable"];
            Assert.AreEqual(expectedCount, wishListBooks.Rows.Count);
        }
    }
}
