using System;
using System.Text.RegularExpressions;

namespace BookStoreLIB
{
     public class UserData
     {
          public int UserID { set; get; }
          public string LoginName { set; get; }
          public string Password { set; get; }
          public string FullName { set; get; }
          public string Address { set; get; }
          public string PostalCode { set; get; }
          public string City { set; get; }
          public string Province { set; get; }
          public string Country { set; get; }
          public string userPassword { set; get; }
          public Boolean isManager { set; get; }

        public string userAddress;
        public Boolean logoutStatus;

        public Boolean LogIn(string loginName, string passWord)
        {
          var dbUser = new DALUserInfo();
          UserID = dbUser.LogIn(loginName, passWord);
          if (UserID > 0)
          {
               LoginName = loginName;
               Password = passWord;
               FullName = dbUser.DbFullName;
               if (dbUser.isManager)
               {
                    isManager = true;
               }

               return true;
          }
          else
               isManager = false;  // manager is false
               return false;
        }

        public Boolean EditInfo(int userid, string fullName, string address, string postalCode, string city, string province, string country)
        {
            var dbUser = new DALUserInfo();
            int retUserId = dbUser.EditInfo(userid, fullName, address, postalCode, city, province, country);
            if (retUserId > 0)
            {
                Address = address;
                FullName = fullName;
                PostalCode = postalCode;
                City = city;
                Province = province;
                Country = country;
                return true;
            }
            else
                return false;

        }

        public Boolean GetInfo(int userid)
        {
            var dbUser = new DALUserInfo();
            int retUserId = dbUser.GetInfo(userid);
            if (retUserId > 0)
            {
                Address = dbUser.userAddress;
                FullName = dbUser.userFullname;
                PostalCode = dbUser.userPostalCode;
                City = dbUser.userCity;
                Province = dbUser.userProvince;
                Country = dbUser.userCountry;
                return true;
            }
            else
                return false;

        }

        public Boolean GetPass(int userid)
        {
            var dbUser = new DALUserInfo();
            int retUserId = dbUser.GetPass(userid);
            if (retUserId > 0)
            {
                userPassword = dbUser.userPassword;
                return true;
            }
            else
                return false;

        }

        public Boolean SetPass(String newPass, int userID)
        {
            var dbUser = new DALUserInfo();
            int retUserId = dbUser.setPass(newPass, userID);
            if (retUserId > 0)
            {
                return true;
            }
            else
                return true;

        }

        public Boolean CreateProfile(String username, String password, String fullname, String address, String postalCode, String city, String province, String country)
        {
            var dbUser = new DALUserInfo();
                int retUserId = dbUser.CreateProfile(username, password, fullname, address, postalCode, city, province, country);
                if (retUserId > 0)
                {
                    LoginName = username;
                    Password = password;
                    FullName = fullname;
                    UserID = retUserId;
                    Address = address;
                    return true;
                }
            else
                return false;
        }

        public Boolean ValidatePassword(String passwd)
        {
            string pattern = @"^(?=.?[A-Za-z])(?=.*?[A-Za-z0-9]).{6,}$";
            Regex reg = new Regex(pattern);
            if (Regex.IsMatch(passwd, pattern))
                return true;
            else
                return false;
        }

        public Boolean ValidateUsername(String username)
        {
            if (checkUserName(username))
                return true;
            else
                return false;
        }

        public Boolean checkUserName (string username)
        {
            var dbUser = new DALUserInfo();
            if (dbUser.validateUserName(username))
                return true;
            else
                return false;
        }

        public void LogoutCheck(Boolean status)
        {
            logoutStatus = status;
        }

    }
}