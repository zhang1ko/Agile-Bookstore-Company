using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace BookStoreLIB
{
   [TestClass]
    public class TestLogout
    {
        UserData user = new UserData();
        Boolean logoutInputStatus;

        [TestMethod]
        public void logoutTest1()
        {
            // define test inputs
            logoutInputStatus = false;
            // define the output values
            Boolean expectedStatus = false;
            // run the method under test
            user.LogoutCheck(logoutInputStatus);
            // verify the result
            Assert.AreEqual(expectedStatus, user.logoutStatus);
        }

        [TestMethod]
        public void logoutTest2()
        {
            // define test inputs
            logoutInputStatus = true;
            // define the output values
            Boolean expectedStatus = true;
            // run the method under test
            user.LogoutCheck(logoutInputStatus);
            // verify the result
            Assert.AreEqual(expectedStatus, user.logoutStatus);
        }
    }
}
