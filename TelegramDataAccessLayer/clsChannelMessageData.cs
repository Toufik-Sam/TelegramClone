using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
namespace TelegramDataAccessLayer
{
    public class clsChannelMessageData
    {
        public static int AddNewChannelMessage(string Message,int ChannelID,DateTime DateOfCreation,int SentByAdminID,string ImagePath)
        {
            int MessageID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_AddNewChannelMessage", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (Message != "" && Message != null)
                            command.Parameters.AddWithValue("@Message", SqlDbType.NVarChar).Value = Message;
                        else
                            command.Parameters.AddWithValue("@Message", SqlDbType.NVarChar).Value = System.DBNull.Value;
                        command.Parameters.AddWithValue("@ChannelID", SqlDbType.Int).Value = ChannelID;
                        command.Parameters.AddWithValue("@DateOfCreation", SqlDbType.DateTime).Value = DateOfCreation;
                        command.Parameters.AddWithValue("@SentByAdminID", SqlDbType.Int).Value = SentByAdminID;
                        if (ImagePath != null && ImagePath != "")
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        else
                            command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
                        SqlParameter OutputParam = new SqlParameter("@NewMessageID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                        command.Parameters.Add(OutputParam);
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageID = (int)command.Parameters["@NewMessageID"].Value;
                    }
                }
                return MessageID;
            }
            catch(Exception ex)
            {
                return -1;
            }

        }
        public static bool UpdateChannelMessage(int MessageID,string Message,int ChannelID,DateTime DateOfCreation,int SentByAdminID,string ImagePath)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_UpdateChannelMessage", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MessageID", SqlDbType.Int).Value = MessageID;
                        if (Message != null && Message != "")
                            command.Parameters.AddWithValue("@Message", SqlDbType.NVarChar).Value = Message;
                        else
                            command.Parameters.AddWithValue("@Message", SqlDbType.NVarChar).Value = System.DBNull.Value;
                        command.Parameters.AddWithValue("@ChannelID", SqlDbType.Int).Value = ChannelID;
                        command.Parameters.AddWithValue("@DateOfCreation", SqlDbType.DateTime).Value = DateOfCreation;
                        command.Parameters.AddWithValue("@SentByAdminID", SqlDbType.Int).Value = SentByAdminID;
                        if (ImagePath != null && ImagePath != "")
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        else
                            command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
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
        public static bool GetChannelMessageInfoByID(int MessageID,ref string Message,ref int ChannelID,ref DateTime DateOfCreation,ref int SentByAdminID,ref string ImagePath)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetChannelMessageInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MessageID", MessageID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Message = (string)reader["Message"];
                                ChannelID = (int)reader["ChannelID"];
                                DateOfCreation = (DateTime)reader["DateOfCreation"];
                                SentByAdminID = (int)reader["SentByAdminID"];
                                if (reader["ImagePath"] != System.DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";
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
    }
}
