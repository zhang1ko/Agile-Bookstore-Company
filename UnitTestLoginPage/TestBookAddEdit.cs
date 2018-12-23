using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookStoreLIB
{
     [TestClass]
     public class TestBookAddEdit
     {
          DALBookAddEdit dbae = new DALBookAddEdit();
          string ISBN;
          string title;
          string author;
          double price;
          int quantity;
          string year;
          string edition;
          string publisher;
          int categoryID;
          int supplierID;
          string newISBN;

          // this is a multi step test to allow the same item to be 
          // add, edited, and deleted each time the test is run 
          [TestMethod]
          public void AddEditRemoveBookTestMethod1()
          {
               // define test inputs
               ISBN = "222222222";
               title = "A Real Life Unit Testing Example";
               author = "Unit Test";
               price = 11.11;
               quantity = 1111;
               year = "1111";
               edition = "1";
               publisher = "Unit Test";
               categoryID = 1;
               supplierID = 1;



               // define the output values
               Boolean expectedReturnAdd = true;
               int expectedReturnRemove = 1;
               int expectedReturnUpdate = 1;
               newISBN = "222222223";

               // run the method under test
               // add
               Boolean actualReturnAdd = dbae.AddBook(ISBN, title, author, price, quantity, year, edition, 
                    publisher, categoryID, supplierID); 
               // update
               int actualReturnUpdate = dbae.UpdateBook(ISBN, newISBN, title, author, price, quantity, 
                    year, edition, publisher, categoryID, supplierID); 
               // remove
               int actualReturnRemove = dbae.RemoveBook(newISBN);

               // verify the result
               Assert.AreEqual(expectedReturnAdd, actualReturnAdd);
               Assert.AreEqual(expectedReturnUpdate, actualReturnUpdate);
               Assert.AreEqual(expectedReturnRemove, actualReturnRemove);
          }
     }
}
