using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookStoreLIB
{
    [TestClass]
    public class TestProfileInfo
    {
        [TestMethod]
        public void TestMethodVerifyUserName()
        {
            UserData user = new UserData();
            String expectedUsername = "testUserName";

            Boolean retBool = user.ValidateUsername(expectedUsername);
            Boolean expBool = true;

            Assert.AreEqual(retBool, expBool);
        
        }

        [TestMethod]
        public void TestMethodVerifyUserName2()
        {
            UserData user = new UserData();
            String expectedUsername = "saeed11b";

            Boolean retBool = user.ValidateUsername(expectedUsername);
            Boolean expBool = false;

            Assert.AreEqual(retBool, expBool);

        }

        [TestMethod]
        public void TestMethodVerifyPassword()
        {
            UserData user = new UserData();
            String expectedPassword = "short";

            Boolean retBool = user.ValidatePassword(expectedPassword);
            Boolean expBool = false;

            Assert.AreEqual(retBool, expBool);

        }

        [TestMethod]
        public void TestMethodVerifyPassword2()
        {
            UserData user = new UserData();
            String expectedPassword = "ValidPwd1";

            Boolean retBool = user.ValidatePassword(expectedPassword);
            Boolean expBool = true;

            Assert.AreEqual(retBool, expBool);

        }

        [TestMethod]
        public void TestMethodVerifyPassword3()
        {
            UserData user = new UserData();
            String expectedPassword = "123456";

            Boolean retBool = user.ValidatePassword(expectedPassword);
            Boolean expBool = false;

            Assert.AreEqual(retBool, expBool);

        }

        [TestMethod]
        public void TestMethodCreateProfile()
        {
            DALUserInfo userInfo = new DALUserInfo();

            String expectedUsername = "testRegister";
            String expectedPassword = "test1234";
            String expectedFullname = "Test Register";
            String expectedAddress = "test";
            String expectedPostalCode = "test";
            String expectedCity = "test";
            String expectedProvince = "tr";
            String expectedCountry = "test";

            int uid = userInfo.CreateProfile(expectedUsername, expectedPassword, expectedFullname,
                expectedAddress, expectedPostalCode, expectedCity, expectedProvince, expectedCountry);

            int actualUserID = userInfo.GetInfo(uid);
            String actualUsername = userInfo.userName;
            String actualPassword = userInfo.userPassword;
            String actualFullname = userInfo.userFullname;
            String actualAddress = userInfo.userAddress;
            String actualPostalCode = userInfo.userPostalCode;
            String actualCity = userInfo.userCity;
            String actualProvince = userInfo.userProvince;
            String actualCountry = userInfo.userCountry;

            Assert.AreEqual(uid, actualUserID);
            Assert.AreEqual(expectedUsername, actualUsername);
            Assert.AreEqual(expectedPassword, actualPassword);
            Assert.AreEqual(expectedFullname, actualFullname);
            Assert.AreEqual(expectedAddress, actualAddress);
            Assert.AreEqual(expectedPostalCode, actualPostalCode);
            Assert.AreEqual(expectedCity, actualCity);
            Assert.AreEqual(expectedProvince, actualProvince);
            Assert.AreEqual(expectedCountry, actualCountry);

            userInfo.deleteUser(uid);
        }

        [TestMethod]
        public void TestMethodEditInfo()
        {
            DALUserInfo userInfo = new DALUserInfo();

            int expectedUserID = 30;
            String expectedFullname = "Test Edit";
            String expectedAddress = "testE";
            String expectedPostalCode = "testE";
            String expectedCity = "testE";
            String expectedProvince = "te";
            String expectedCountry = "testE";

            int userID = userInfo.EditInfo(expectedUserID, expectedFullname, expectedAddress,
                expectedPostalCode, expectedCity, expectedProvince, expectedCountry);

            int actualUserID = userInfo.GetInfo(expectedUserID);

            String actualFullname = userInfo.userFullname;
            String actualAddress = userInfo.userAddress;
            String actualPostalCode = userInfo.userPostalCode;
            String actualCity = userInfo.userCity;
            String actualProvince = userInfo.userProvince;
            String actualCountry = userInfo.userCountry;

            Assert.AreEqual(expectedFullname, actualFullname);
            Assert.AreEqual(expectedAddress, actualAddress);
            Assert.AreEqual(expectedPostalCode, actualPostalCode);
            Assert.AreEqual(expectedCity, actualCity);
            Assert.AreEqual(expectedProvince, actualProvince);
            Assert.AreEqual(expectedCountry, actualCountry);
        }
    }
}

