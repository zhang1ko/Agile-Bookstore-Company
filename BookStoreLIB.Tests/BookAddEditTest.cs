// <copyright file="BookAddEditTest.cs">Copyright ©  2018</copyright>

using System;
using BookStoreLIB;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookStoreLIB.Tests
{
    [TestClass]
    [PexClass(typeof(BookAddEdit))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class BookAddEditTest
    {

          [PexMethod(MaxBranches = 20000)]
          public string AddBook(
              [PexAssumeUnderTest]BookAddEdit target,
              string ISBN,
              string title,
              string author,
              double price,
              int quantity,
              string year,
              string edition,
              string publisher,
              int categoryID,
              int supplierID
          )
          {
               string result = target.AddBook
                                   (ISBN, title, author, price, quantity, year, edition, publisher, categoryID, supplierID);
               return result;
               // TODO: add assertions to method BookAddEditTest.AddBook(BookAddEdit, String, String, String, Double, Int32, String, String, String, Int32, Int32)
          }
     }
}
