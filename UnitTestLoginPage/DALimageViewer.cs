using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;

namespace BookStoreLIB
{
    class DALimageViewer
    {
        public String imageName { get; set; }

        public int imageID { get; set; }

        public int getImage(int ISBN)
        {
            var conn = new SqlConnection(BookStoreLIB.Properties.Settings.Default.tfsConnection);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select Id, imgName from imageData where "
                     + "ISBN = @ISBN";
                cmd.Parameters.AddWithValue("@ISBN", ISBN);
                conn.Open();
                //int userID = (int)cmd.ExecuteScalar();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    imageID = (int)reader["Id"];

                    imageName = reader["imgName"].ToString();
                }

                reader.Close();

                if (imageID > 0) return imageID;
                else return -1;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return -1;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open);
                conn.Close();
            }
        }
    }
}
