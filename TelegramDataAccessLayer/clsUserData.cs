using System;
using System.Data;
using System.Data.SqlClient;
namespace TelegramDataAccessLayer
{
    public class clsUserData
    {
        public static int AddNewUser(string FirstName,string LastName,string Phone,string ImagePath)
        {
            int UserID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_AddNewUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FirstName", SqlDbType.NVarChar).Value = FirstName;
                        command.Parameters.AddWithValue("@LastName", SqlDbType.NVarChar).Value = LastName;
                        command.Parameters.AddWithValue("@Phone", SqlDbType.NVarChar).Value = Phone;
                        if (ImagePath != "" && ImagePath != null)
                            command.Parameters.AddWithValue("@ImagePath", SqlDbType.NVarChar).Value = ImagePath;
                        else
                            command.Parameters.AddWithValue("@ImagePath", SqlDbType.NVarChar).Value = null;
                        SqlParameter OutputIDparam = new SqlParameter("@NewPersonID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(OutputIDparam);
                        connection.Open();
                        command.ExecuteNonQuery();
                        UserID = (int)command.Parameters["@NewPersonID"].Value;
                    }
                }
                return UserID;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public static bool UpdateUser(int UserID,string FirstName,string LastName,string Phone,string ImagePath)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_UpdateUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = UserID;
                        command.Parameters.AddWithValue("@FirstName", SqlDbType.NVarChar).Value = FirstName;
                        command.Parameters.AddWithValue("@LastName", SqlDbType.NVarChar).Value = LastName;
                        command.Parameters.AddWithValue("@Phone", SqlDbType.NVarChar).Value = Phone;
                        if (ImagePath != "" && ImagePath != null)
                            command.Parameters.AddWithValue("@ImagePath", SqlDbType.NVarChar).Value = ImagePath;
                        else
                            command.Parameters.AddWithValue("@ImagePath", SqlDbType.NVarChar).Value = null;
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
                return rowsAffected > 0;
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }
        public static bool GetUserInfoByID(int UserID,ref string FirstName,ref string LastName,ref string Phone,ref string ImagePath)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetUserInfoByID", connection))
                    {
                        connection.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", UserID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                FirstName = (string)reader["FirstName"];
                                LastName = (string)reader["LastName"];
                                Phone = (string)reader["Phone"];
                                if (reader["ImagePath"] != System.DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";
                                isFound = true;
                            }

                        }
                    }
                    return isFound;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
   
        }
        public static bool GetUserInfoByPhoneNum(string Phone,ref int UserID,ref string FirstName,ref string LastName,ref string ImagePath)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetUserInfoByPhone", connection))
                    {
                        connection.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Phone", Phone);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                FirstName = (string)reader["FirstName"];
                                LastName = (string)reader["LastName"];
                                UserID = (int)reader["UserID"];
                                if (reader["ImagePath"] != System.DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";
                                isFound = true;
                            }
                        }
                    }
                }
                return isFound;
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }
        public static DataTable SearchForPublicEntities(int UserID,string FilterValue)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Select * From dbo.SearchForPublicEntities(@UserID,@FilterValue)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@FilterValue", FilterValue);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                }
                return dt;
            }
            catch(Exception ex)
            {
                return null;
            }

        }
    }
}
