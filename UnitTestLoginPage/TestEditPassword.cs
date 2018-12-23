using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookStoreLIB
{
        [TestClass]
        public class TestEditPassword
        {
            UserData user = new UserData();
            String newPassword, staticPassword;
            int userID = 16;

            [TestMethod]
            public void logoutEditPassword()
            {
                //Running Function to set Passwords
                staticPassword = "editpass1234";
                user.SetPass(staticPassword, userID);
                // define test inputs
                newPassword = "editpass123";
                //Setting the new Password
                user.SetPass(newPassword, userID);
                user.GetPass(userID);
                //setting output values
                string currentPassword = user.userPassword;
                
                // verify the result
                Assert.AreEqual(newPassword, currentPassword);
            }
        }
    }
