using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookStoreLIB
{
    [TestClass]
    public class TestPreview
    {
        imageViewer image = new imageViewer();
        int inputISBN;

        [TestMethod]
        public void TestMethod1() //If the ISBN is in the database
        {
            // define test inputs
            inputISBN = 0135974446;
            // define the output values
            Boolean expectedReturn = true;
            // run the method under test
            Boolean actualReturn = image.imgSeeker(inputISBN);
            // verify the result
            Assert.AreEqual(expectedReturn, actualReturn);
        }

        [TestMethod]
        public void TestMethod2() //If the ISBN is not in the database
        {
            // define test inputs
            inputISBN = 0;
            // define the output values
            Boolean expectedReturn = false;
            // run the method under test
            Boolean actualReturn = image.imgSeeker(inputISBN);
            // verify the result
            Assert.AreEqual(expectedReturn, actualReturn);
        }

        [TestMethod]
        public void TestMethod3() //If the ISBN is not in the database
        {
            // define test inputs
            inputISBN = 111111111; //Wrong ISBN
            // define the output values
            Boolean expectedReturn = false;
            // run the method under test
            Boolean actualReturn = image.imgSeeker(inputISBN);
            // verify the result
            Assert.AreEqual(expectedReturn, actualReturn);
        }

    }
}
