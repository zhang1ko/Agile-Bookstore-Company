using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace BookStoreLIB
{
     class DALUserInfo
     {
          public string DbFullName { get; set; }
          public int userID { get; set; }
          public Boolean isManager;
          public int test;

        public string userName { get; set; }
        public string userFullname { get; set; }
        public string userAddress { get; set; }
        public string userPostalCode { get; set; }
        public string userCity { get; set; }
        public string userProvince { get; set; }
        public string userCountry { get; set; }
        public string userPassword { get; set; }

        public int LogIn(string UserName, string Password)
        {
            //var conn = new SqlConnection(BookStoreLIB.Properties.Settings.Default.bdConnection);
            var conn = new SqlConnection(BookStoreLIB.Properties.Settings.Default.tfsConnection);
               try
               {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Select UserID, FullName, Manager from UserData where "
                         + " UserName = @UserName and Password = @Password";
                    cmd.Parameters.AddWithValue("@UserName", UserName);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    conn.Open();
                    //int userID = (int)cmd.ExecuteScalar();
                    
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                         userID = (int)reader["UserID"];
                         DbFullName = reader["FullName"].ToString();
                         isManager = (bool)reader["Manager"];
                    }

                    reader.Close();

                    if (userID > 0)
                        return userID;
                    else
                        return -1;
               }
               catch (Exception ex)
               {
                    Debug.WriteLine(ex.ToString());
                    return -1;
               }
               finally
               {
                    if (conn.State == System.Data.ConnectionState.Open) ;
                    conn.Close();
               }
          }

        public int EditInfo(int userid, string name, string addr, string postalCode, string city, string province, string country)
        {
            //var conn = new SqlConnection(BookStoreLIB.Properties.Settings.Default.bdConnection);
            var conn = new SqlConnection(BookStoreLIB.Properties.Settings.Default.tfsConnection);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Update UserData SET "
                     + "FullName = @FullName, Address = @Address, PostalCode = @PostalCode, City = @City, Province = @Province, Country = @Country"
                     + " where UserID = @UserID";
                cmd.Parameters.AddWithValue("@FullName", name);
                cmd.Parameters.AddWithValue("@Address", addr);
                cmd.Parameters.AddWithValue("@PostalCode", postalCode);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@Province", province);
                cmd.Parameters.AddWithValue("@Country", country);
                cmd.Parameters.AddWithValue("@UserID", userid);

                conn.Open();
                int userID = (int)cmd.ExecuteScalar();

                if (userID > 0)
                    return userID;
                else
                    return -1;
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return -1;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        public int GetInfo(int userid)
        {
            //var conn = new SqlConnection(BookStoreLIB.Properties.Settings.Default.bdConnection);
            var conn = new SqlConnection(BookStoreLIB.Properties.Settings.Default.tfsConnection);
            try
            {
                userID = userid;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT FullName, UserName, Password, Address, PostalCode, City, Province, Country FROM UserData WHERE UserID = @UserID";
                cmd.Parameters.AddWithValue("@UserID", userid);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    userFullname = reader["FullName"].ToString();
                    userAddress = reader["Address"].ToString();
                    userName = reader["UserName"].ToString();
                    userPassword = reader["Password"].ToString();
                    userPostalCode = reader["PostalCode"].ToString();
                    userCity = reader["City"].ToString();
                    userProvince = reader["Province"].ToString();
                    userCountry = reader["Country"].ToString();
                }

                reader.Close();

                if (userID > 0)
                    return userID;
                else
                    return -1;
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return -1;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        public int GetPass(int userid)
        {
            //var conn = new SqlConnection(BookStoreLIB.Properties.Settings.Default.bdConnection);
            var conn = new SqlConnection(BookStoreLIB.Properties.Settings.Default.tfsConnection);
            try
            {
                userID = userid;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT Password FROM UserData WHERE UserID = @UserID";
                cmd.Parameters.AddWithValue("@UserID", userid);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    userPassword = reader["Password"].ToString();
                }

                reader.Close();

                if (userID > 0)
                    return userID;
                else
                    return -1;
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return -1;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        public int setPass(String newPass, int uID)
        {
            var conn = new SqlConnection(BookStoreLIB.Properties.Settings.Default.tfsConnection);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Update UserData SET "
                     + "Password = @Password"
                     + " where UserID = @UserID";
                cmd.Parameters.AddWithValue("@Password", newPass);
                cmd.Parameters.AddWithValue("@UserID", uID);
                conn.Open();

                int userID = (int)cmd.ExecuteNonQuery();

                if (userID > 0)
                    return userID;
                else
                    return -1;
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return -1;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        public int CreateProfile(String username, String password, String fullname, String address, String postalCode, String city, String province, String country)
        {
            Boolean manager = false;
            var conn = new SqlConnection(BookStoreLIB.Properties.Settings.Default.tfsConnection);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Insert into UserData (UserName, Password, Manager, FullName, Address, PostalCode, City, Province, Country) "
                     + "Values (@UserName, @Password, @Manager, @FullName, @Address, @PostalCode, @City, @Province, @Country)";
                cmd.Parameters.AddWithValue("@UserName", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Manager", (bool) manager);
                cmd.Parameters.AddWithValue("@FullName", fullname);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@PostalCode", postalCode);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@Province", province);
                cmd.Parameters.AddWithValue("@Country", country);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                int userID = LogIn(username, password);

                if (userID > 0)
                    return userID;
                else
                    return -1;
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return -1;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        public Boolean validateUserName(string username)
        {
            var conn = new SqlConnection(BookStoreLIB.Properties.Settings.Default.tfsConnection);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select Count(*) from UserData where "
                     + " UserName = @UserName ";
                cmd.Parameters.AddWithValue("@UserName", username);

                conn.Open();
                int userID = (int)cmd.ExecuteScalar();

                if (userID == 0)
                    return true;
                else
                    return false;
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }

            finally
            {
                if (conn.State == System.Data.ConnectionState.Open);
                conn.Close();
            }
        }

        public Boolean deleteUser(int userid)
        {
            var conn = new SqlConnection(BookStoreLIB.Properties.Settings.Default.tfsConnection);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM UserData WHERE "
                     + "UserID = @UserID";
                cmd.Parameters.AddWithValue("@UserID", userid);

                conn.Open();
                int userID = (int)cmd.ExecuteScalar();

                if (userID == 0)
                    return true;
                else
                    return false;
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }

            finally
            {
                if (conn.State == System.Data.ConnectionState.Open) ;
                conn.Close();
            }
        }

        public DALUserInfo()
        {
        }
    }
}
