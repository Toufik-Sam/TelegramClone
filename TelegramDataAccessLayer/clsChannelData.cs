using System.Data.SqlClient;
using System.Data;
using System;
namespace TelegramDataAccessLayer
{
    public class clsChannelData
    {
        public static int AddNewChannel(int CreatedByUserID, string ChannelName,string ChannelDescription,bool ChannelType, string ChannelImagePath)
        {
            int ChannelID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_AddNewChannel", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CreatedByUserID", SqlDbType.Int).Value = CreatedByUserID;
                        command.Parameters.AddWithValue("@ChannelName", SqlDbType.NVarChar).Value = ChannelName;
                        command.Parameters.AddWithValue("@ChannelDescription", SqlDbType.NVarChar).Value = ChannelDescription;
                        command.Parameters.AddWithValue("@ChannelType", SqlDbType.Bit).Value = ChannelType;
                        if (ChannelImagePath != null && ChannelImagePath != "")
                            command.Parameters.AddWithValue("@ChannelImagePath", SqlDbType.NVarChar).Value = ChannelImagePath;
                        else
                            command.Parameters.AddWithValue("@ChannelImagePath", SqlDbType.NVarChar).Value = System.DBNull.Value;
                        SqlParameter OutputIDparam = new SqlParameter("@NewChannelID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(OutputIDparam);
                        connection.Open();
                        command.ExecuteNonQuery();
                        ChannelID = (int)command.Parameters["@NewChannelID"].Value;
                    }
                }
                return ChannelID;
            }
            catch(Exception ex)
            {
                return -1;
            }

        }
        public static bool UpdateChannel(int ChannelID, int CreatedByUserID, string ChannelName,string ChannelDescription,bool ChannelType, string ChannelImagePath)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_UpdateChannel", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ChannelID", SqlDbType.Int).Value = ChannelID;
                        command.Parameters.AddWithValue("@CreatedByUserID", SqlDbType.Int).Value = CreatedByUserID;
                        command.Parameters.AddWithValue("@ChannelName", SqlDbType.NVarChar).Value = ChannelName;
                        command.Parameters.AddWithValue("@ChannelDescription", SqlDbType.NVarChar).Value = ChannelDescription;
                        command.Parameters.AddWithValue("@ChannelType", SqlDbType.Bit).Value = ChannelType;
                        if (ChannelImagePath != null && ChannelImagePath != "")
                            command.Parameters.AddWithValue("@ChannelImagePath", SqlDbType.NVarChar).Value = ChannelImagePath;
                        else
                            command.Parameters.AddWithValue("@ChannelImagePath", SqlDbType.NVarChar).Value = System.DBNull.Value;
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
        public static DataTable GetChannelMessages(int ChannelID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetChannelMessages", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("ChannelID", SqlDbType.Int).Value = ChannelID;
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
        public static string GetChannelImagePath(int ChannelID)
        {
            string ImagePath = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("Select dbo.GetChannelImagePath(@ChannelID)", connection))
                    {
                        command.Parameters.AddWithValue("@ChannelID", SqlDbType.Int).Value = ChannelID;
                        connection.Open();
                        if (command.ExecuteScalar() != System.DBNull.Value)
                            ImagePath = command.ExecuteScalar().ToString();
                        else
                            ImagePath = "";
                    }
                }
                return ImagePath;
            }
            catch(Exception ex)
            {
                return "";
            }
        }
        public static bool GetChanneInfoByID(int ChannelID, ref int CreatedByUserID, ref string ChannelName,ref string ChannelDescription,ref bool ChannelType,ref string ChannelImagePath)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetChannelInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ChannelID", SqlDbType.Int).Value = ChannelID;
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CreatedByUserID = (int)reader["createdByUserID"];
                                ChannelName = (string)reader["ChannelName"];
                                ChannelDescription = (string)reader["ChannelDescription"];
                                ChannelType = (bool)reader["ChannelType"];
                                if (reader["ChannelImagePath"] != System.DBNull.Value)
                                    ChannelImagePath = (string)reader["ChannelImagePath"];
                                else
                                    ChannelImagePath = "";
                                IsFound = true;
                            }
                        }
                    }
                }
                return IsFound;
            }
            catch(Exception ex)
            {
                return false;
            }

        }
        public static bool DeleteChannelByID(int ChannelID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_DeleteChannelByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ChannelID", SqlDbType.Int).Value = ChannelID;
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
    }
}
