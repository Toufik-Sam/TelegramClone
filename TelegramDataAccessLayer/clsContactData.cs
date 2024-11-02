using System.Data.SqlClient;
using System.Data;
using System;
namespace TelegramDataAccessLayer
{
    public class clsContactData
    {
        public static int AddNewContact(int FirstUserID,int SecondUserID)
        {
            int ContactID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_AddNewContact", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FirstUserID", SqlDbType.Int).Value = FirstUserID;
                        command.Parameters.AddWithValue("@SecondUserID", SqlDbType.NVarChar).Value = SecondUserID;

                        SqlParameter OutputIDparam = new SqlParameter("@NewContactID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(OutputIDparam);
                        connection.Open();
                        command.ExecuteNonQuery();
                        ContactID = (int)command.Parameters["@NewGroupID"].Value;
                    }
                }
                return ContactID;
            }
            catch(Exception ex)
            {
                return -1;
            }

        }
        public static bool UpdateContact(int ContactID,int FirstUserID,int SecondUserID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_UpdateContact", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ContactID", SqlDbType.Int).Value = ContactID;
                        command.Parameters.AddWithValue("@FirstUserID", SqlDbType.Int).Value = FirstUserID;
                        command.Parameters.AddWithValue("@SecondUserID", SqlDbType.NVarChar).Value = SecondUserID;
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
        public static bool DeleteContactByID(int FirstUserID,int SecondUserID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_DeleteContact", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FirstUserID", SqlDbType.Int).Value = FirstUserID;
                        command.Parameters.AddWithValue("@SecondUserID", SqlDbType.Int).Value = SecondUserID;
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
        public static DataTable GetUserContacts(int UserID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Select * from dbo.GetUserContactsInfo(@UserID)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
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
        public static DataTable SearchInUserContacts(int UserID,string FilterValue)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Select * From dbo.SearchInUserContactsInfo(@UserID,@FilterValue)";
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
