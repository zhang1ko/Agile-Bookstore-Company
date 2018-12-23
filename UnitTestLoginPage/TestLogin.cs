using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookStoreLIB
{
     [TestClass]
     public class TestLogin
     {
          UserData userData = new UserData();
          string inputName, inputPassword;
          int actualUserID;
          Boolean isManager;

          [TestMethod]
          public void TestMethod1()
          {
               // define test inputs
               inputName = "Zhang1ko";
               inputPassword = "vz12995";
               // define the output values
               Boolean expectedReturn = true;
               int expectedUserID = 6;
               Boolean expectedMagager = false;
               // run the method under test
               Boolean actualReturn = userData.LogIn(inputName, inputPassword);
               actualUserID = userData.UserID;
               isManager = userData.isManager;
               // verify the result
               Assert.AreEqual(expectedReturn, actualReturn);
               Assert.AreEqual(expectedUserID, actualUserID);
               Assert.AreEqual(expectedMagager, isManager);
          }

          [TestMethod]
          public void TestMethod2()
          {
               // define test inputs
               inputName = "";               // "Ferna11i";
               inputPassword = "JF38466";
               // define the output values
               Boolean expectedReturn = false;
               int expectedUserID = -1;
               // run the method under test
               Boolean actualReturn = userData.LogIn(inputName, inputPassword);
               actualUserID = userData.UserID;
               // verify the result
               Assert.AreEqual(expectedReturn, actualReturn);
               Assert.AreEqual(expectedUserID, actualUserID);
          }

          [TestMethod]
          public void TestMethod3()
          {
               // define test inputs
               inputName = "Ferna11ii";       // "Ferna11i";
               inputPassword = "JF38466";
               // define the output values
               Boolean expectedReturn = false;
               int expectedUserID = -1;
               // run the method under test
               Boolean actualReturn = userData.LogIn(inputName, inputPassword);
               actualUserID = userData.UserID;
               // verify the result
               Assert.AreEqual(expectedReturn, actualReturn);
               Assert.AreEqual(expectedUserID, actualUserID);
          }

          [TestMethod]
          public void TestMethod4()
          {
               // define test inputs
               inputName = "Ferna11i";               // "Ferna11i";
               inputPassword = "JG38466";
               // define the output values
               Boolean expectedReturn = false;
               int expectedUserID = -1;
               // run the method under test
               Boolean actualReturn = userData.LogIn(inputName, inputPassword);
               actualUserID = userData.UserID;
               // verify the result
               Assert.AreEqual(expectedReturn, actualReturn);
               Assert.AreEqual(expectedUserID, actualUserID);
          }

          [TestMethod]
          public void TestMethod5()
          {
               // define test inputs
               inputName = "Ferna11i";               // "Ferna11i";
               inputPassword = "JF38466#";
               // define the output values
               Boolean expectedReturn = false;
               int expectedUserID = -1;
               // run the method under test
               Boolean actualReturn = userData.LogIn(inputName, inputPassword);
               actualUserID = userData.UserID;
               // verify the result
               Assert.AreEqual(expectedReturn, actualReturn);
               Assert.AreEqual(expectedUserID, actualUserID);
          }

          [TestMethod]
          public void TestMethod6()
          {
               // define test inputs
               inputName = "Ferna11i";               // "Ferna11i";
               inputPassword = "";
               // define the output values
               Boolean expectedReturn = false;
               int expectedUserID = -1;
               // run the method under test
               Boolean actualReturn = userData.LogIn(inputName, inputPassword);
               actualUserID = userData.UserID;
               // verify the result
               Assert.AreEqual(expectedReturn, actualReturn);
               Assert.AreEqual(expectedUserID, actualUserID);
          }

          [TestMethod]
          public void TestMethod7()
          {
               // define test inputs
               inputName = "";               // "Ferna11i";
               inputPassword = "";
               // define the output values
               Boolean expectedReturn = false;
               int expectedUserID = -1;
               // run the method under test
               Boolean actualReturn = userData.LogIn(inputName, inputPassword);
               actualUserID = userData.UserID;
               // verify the result
               Assert.AreEqual(expectedReturn, actualReturn);
               Assert.AreEqual(expectedUserID, actualUserID);
          }

          [TestMethod]
          public void TestMethod8()
          {
               // define test inputs
               inputName = "";               // "Ferna11i";
               inputPassword = "f";           // JF38466
               // define the output values
               Boolean expectedReturn = false;
               int expectedUserID = -1;
               // run the method under test
               Boolean actualReturn = userData.LogIn(inputName, inputPassword);
               actualUserID = userData.UserID;
               // verify the result
               Assert.AreEqual(expectedReturn, actualReturn);
               Assert.AreEqual(expectedUserID, actualUserID);
          }

          [TestMethod]
          public void TestMethod9()
          {
               // define test inputs
               inputName = "";               // "Ferna11i";
               inputPassword = "6";           // JF38466
               // define the output values
               Boolean expectedReturn = false;
               int expectedUserID = -1;
               // run the method under test
               Boolean actualReturn = userData.LogIn(inputName, inputPassword);
               actualUserID = userData.UserID;
               // verify the result
               Assert.AreEqual(expectedReturn, actualReturn);
               Assert.AreEqual(expectedUserID, actualUserID);
          }

          [TestMethod]
          public void TestMethod10()
          {
               // define test inputs
               inputName = "";               // "Ferna11i";
               inputPassword = "2f";           // JF38466
               // define the output values
               Boolean expectedReturn = false;
               int expectedUserID = -1;
               // run the method under test
               Boolean actualReturn = userData.LogIn(inputName, inputPassword);
               actualUserID = userData.UserID;
               // verify the result
               Assert.AreEqual(expectedReturn, actualReturn);
               Assert.AreEqual(expectedUserID, actualUserID);
          }

          [TestMethod]
          public void TestMethod11()
          {
               // define test inputs
               inputName = "";               // "Ferna11i";
               inputPassword = "abcdefg";           // JF38466
               // define the output values
               Boolean expectedReturn = false;
               int expectedUserID = -1;
               // run the method under test
               Boolean actualReturn = userData.LogIn(inputName, inputPassword);
               actualUserID = userData.UserID;
               // verify the result
               Assert.AreEqual(expectedReturn, actualReturn);
               Assert.AreEqual(expectedUserID, actualUserID);
          }

          [TestMethod]
          public void TestMethod12()
          {
               // define test inputs
               inputName = "";               // "Ferna11i";
               inputPassword = "1234567";           // JF38466
               // define the output values
               Boolean expectedReturn = false;
               int expectedUserID = -1;
               // run the method under test
               Boolean actualReturn = userData.LogIn(inputName, inputPassword);
               actualUserID = userData.UserID;
               // verify the result
               Assert.AreEqual(expectedReturn, actualReturn);
               Assert.AreEqual(expectedUserID, actualUserID);
          }

          [TestMethod]
          public void TestMethod13()
          {
               // define test inputs
               inputName = "";               // "Ferna11i";
               inputPassword = "abcd123";           // JF38466
               // define the output values
               Boolean expectedReturn = false;
               int expectedUserID = -1;
               // run the method under test
               Boolean actualReturn = userData.LogIn(inputName, inputPassword);
               actualUserID = userData.UserID;
               // verify the result
               Assert.AreEqual(expectedReturn, actualReturn);
               Assert.AreEqual(expectedUserID, actualUserID);
          }

          [TestMethod]
          public void TestMethod14()
          {
               // define test inputs
               inputName = "Ferna11ix";               // "Ferna11i";
               inputPassword = "";           // JF38466
               // define the output values
               Boolean expectedReturn = false;
               int expectedUserID = -1;
               // run the method under test
               Boolean actualReturn = userData.LogIn(inputName, inputPassword);
               actualUserID = userData.UserID;
               // verify the result
               Assert.AreEqual(expectedReturn, actualReturn);
               Assert.AreEqual(expectedUserID, actualUserID);
          }

          [TestMethod]
          public void TestMethod15()
          {
               // define test inputs
               inputName = "Ferna11ix";               // "Ferna11i";
               inputPassword = "gad";           // JF38466
               // define the output values
               Boolean expectedReturn = false;
               int expectedUserID = -1;
               // run the method under test
               Boolean actualReturn = userData.LogIn(inputName, inputPassword);
               actualUserID = userData.UserID;
               // verify the result
               Assert.AreEqual(expectedReturn, actualReturn);
               Assert.AreEqual(expectedUserID, actualUserID);
          }

          [TestMethod]
          public void TestMethod16()
          {
               // define test inputs
               inputName = "Ferna11ix";               // "Ferna11i";
               inputPassword = "34";           // JF38466
               // define the output values
               Boolean expectedReturn = false;
               int expectedUserID = -1;
               // run the method under test
               Boolean actualReturn = userData.LogIn(inputName, inputPassword);
               actualUserID = userData.UserID;
               // verify the result
               Assert.AreEqual(expectedReturn, actualReturn);
               Assert.AreEqual(expectedUserID, actualUserID);
          }

          [TestMethod]
          public void TestMethod17()
          {
               // define test inputs
               inputName = "Ferna11ix";               // "Ferna11i";
               inputPassword = "g35g";           // JF38466
               // define the output values
               Boolean expectedReturn = false;
               int expectedUserID = -1;
               // run the method under test
               Boolean actualReturn = userData.LogIn(inputName, inputPassword);
               actualUserID = userData.UserID;
               // verify the result
               Assert.AreEqual(expectedReturn, actualReturn);
               Assert.AreEqual(expectedUserID, actualUserID);
          }

          [TestMethod]
          public void TestMethod18()
          {
               // define test inputs
               inputName = "Ferna11ix";               // "Ferna11i";
               inputPassword = "gsdfgsdds";           // JF38466
               // define the output values
               Boolean expectedReturn = false;
               int expectedUserID = -1;
               // run the method under test
               Boolean actualReturn = userData.LogIn(inputName, inputPassword);
               actualUserID = userData.UserID;
               // verify the result
               Assert.AreEqual(expectedReturn, actualReturn);
               Assert.AreEqual(expectedUserID, actualUserID);
          }

          [TestMethod]
          public void TestMethod19()
          {
               // define test inputs
               inputName = "Ferna11ix";               // "Ferna11i";
               inputPassword = "343252323";           // JF38466
               // define the output values
               Boolean expectedReturn = false;
               int expectedUserID = -1;
               // run the method under test
               Boolean actualReturn = userData.LogIn(inputName, inputPassword);
               actualUserID = userData.UserID;
               // verify the result
               Assert.AreEqual(expectedReturn, actualReturn);
               Assert.AreEqual(expectedUserID, actualUserID);
          }

          [TestMethod]
          public void TestMethod21()
          {
               // define test inputs
               inputName = "Ferna11i";               // "Ferna11i";
               inputPassword = "hjk";           // JF38466
               // define the output values
               Boolean expectedReturn = false;
               int expectedUserID = -1;
               // run the method under test
               Boolean actualReturn = userData.LogIn(inputName, inputPassword);
               actualUserID = userData.UserID;
               // verify the result
               Assert.AreEqual(expectedReturn, actualReturn);
               Assert.AreEqual(expectedUserID, actualUserID);
          }

          [TestMethod]
          public void TestMethod22()
          {
               // define test inputs
               inputName = "Ferna11i";               // "Ferna11i";
               inputPassword = "345";           // JF38466
               // define the output values
               Boolean expectedReturn = false;
               int expectedUserID = -1;
               // run the method under test
               Boolean actualReturn = userData.LogIn(inputName, inputPassword);
               actualUserID = userData.UserID;
               // verify the result
               Assert.AreEqual(expectedReturn, actualReturn);
               Assert.AreEqual(expectedUserID, actualUserID);
          }

          [TestMethod]
          public void TestMethod23()
          {
               // define test inputs
               inputName = "Ferna11i";               // "Ferna11i";
               inputPassword = "12sd";           // JF38466
               // define the output values
               Boolean expectedReturn = false;
               int expectedUserID = -1;
               // run the method under test
               Boolean actualReturn = userData.LogIn(inputName, inputPassword);
               actualUserID = userData.UserID;
               // verify the result
               Assert.AreEqual(expectedReturn, actualReturn);
               Assert.AreEqual(expectedUserID, actualUserID);
          }

          [TestMethod]
          public void TestMethod24()
          {
               // define test inputs
               inputName = "Ferna11i";               // "Ferna11i";
               inputPassword = "dfsgdfshj";           // JF38466
               // define the output values
               Boolean expectedReturn = false;
               int expectedUserID = -1;
               // run the method under test
               Boolean actualReturn = userData.LogIn(inputName, inputPassword);
               actualUserID = userData.UserID;
               // verify the result
               Assert.AreEqual(expectedReturn, actualReturn);
               Assert.AreEqual(expectedUserID, actualUserID);
          }

          [TestMethod]
          public void TestMethod25()
          {
               // define test inputs
               inputName = "Ferna11i";               // "Ferna11i";
               inputPassword = "124325435";           // JF38466
               // define the output values
               Boolean expectedReturn = false;
               int expectedUserID = -1;
               // run the method under test
               Boolean actualReturn = userData.LogIn(inputName, inputPassword);
               actualUserID = userData.UserID;
               // verify the result
               Assert.AreEqual(expectedReturn, actualReturn);
               Assert.AreEqual(expectedUserID, actualUserID);
          }
     }
     [TestClass]
     public class TestManagerUser
     {
          UserData userData = new UserData();
          string inputName, inputPassword;
          int actualUserID;
          Boolean isManager;

          [TestMethod]
          public void TestMethod1()
          {
               // define test inputs
               inputName = "testadmin";               // "testadmin";
               inputPassword = "test1234";           // test1234
               // define the output values
               Boolean expectedReturn = true;
               int expectedUserID = 11;
               Boolean expectedIsManager = true;
               // run the method under test
               Boolean actualReturn = userData.LogIn(inputName, inputPassword);
               actualUserID = userData.UserID;
               isManager = userData.isManager;
               // verify the result
               Assert.AreEqual(expectedReturn, actualReturn);
               Assert.AreEqual(expectedUserID, actualUserID);
               Assert.AreEqual(expectedIsManager, isManager);
          }
     }
}