using System;
using System.Data;
using System.Data.SqlClient;

namespace TelegramDataAccessLayer
{
    public class clsGroupMessageData
    {
        public static int AddNewGroupMessage(int SentByMemberID,string Message,int GroupID,DateTime DateOfCreation,
            int ReplyToMessageID,string ImagePath,int SharedPostID)
        {
            int MessageID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_AddNewGroupMessage", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SentByMemberID", SqlDbType.Int).Value = SentByMemberID;
                        if (Message != "" && Message != null)
                            command.Parameters.AddWithValue("@Message", SqlDbType.NVarChar).Value = Message;
                        else
                            command.Parameters.AddWithValue("@Message", SqlDbType.NVarChar).Value = System.DBNull.Value;
                        command.Parameters.AddWithValue("@GroupID", SqlDbType.Int).Value = GroupID;
                        command.Parameters.AddWithValue("@DateOfCreation", SqlDbType.DateTime).Value = DateOfCreation;
                        if (ReplyToMessageID == -1)
                            command.Parameters.AddWithValue("@ReplyToMessageID", SqlDbType.Int).Value = System.DBNull.Value;
                        else
                            command.Parameters.AddWithValue("@ReplyToMessageID", SqlDbType.Int).Value = ReplyToMessageID;
                        if (ImagePath != "" && ImagePath != null)
                            command.Parameters.AddWithValue("@ImagePath", SqlDbType.NVarChar).Value = ImagePath;
                        else
                            command.Parameters.AddWithValue("@ImagePath", SqlDbType.NVarChar).Value = System.DBNull.Value;
                        if (SharedPostID == -1)
                            command.Parameters.AddWithValue("@SharedPostID", SqlDbType.Int).Value = System.DBNull.Value;
                        else
                            command.Parameters.AddWithValue("@SharedPostID", SqlDbType.Int).Value = SharedPostID;

                        SqlParameter OutputIDparam = new SqlParameter("@NewMessageID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                        command.Parameters.Add(OutputIDparam);
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageID = (int)command.Parameters["@NewMessageID"].Value;
                    }
                }
                return MessageID;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public static bool UpdateGroupMessage(int MessageID,int SentByMemberID,string Message,int GroupID,DateTime DateOfCreation,
            int ReplyToMessageID,string ImagePath,int SharedPostID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_UpdateGroupMessage", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MessageID", SqlDbType.Int).Value = MessageID;
                        command.Parameters.AddWithValue("@SentByMemberID", SqlDbType.Int).Value = SentByMemberID;
                        command.Parameters.AddWithValue("@Message", SqlDbType.NVarChar).Value = Message;
                        command.Parameters.AddWithValue("@GroupID", SqlDbType.Int).Value = GroupID;
                        command.Parameters.AddWithValue("@DateOfCreation", SqlDbType.DateTime).Value = DateOfCreation;
                        if (ReplyToMessageID == -1)
                            command.Parameters.AddWithValue("@ReplyToMessageID", SqlDbType.Int).Value = System.DBNull.Value;
                        else
                            command.Parameters.AddWithValue("@ReplyToMessageID", SqlDbType.Int).Value = ReplyToMessageID;
                        if (ImagePath != "" && ImagePath != null)
                            command.Parameters.AddWithValue("@ImagePath", SqlDbType.NVarChar).Value = ImagePath;
                        else
                            command.Parameters.AddWithValue("@ImagePath", SqlDbType.NVarChar).Value = System.DBNull.Value;
                        if (SharedPostID == -1)
                            command.Parameters.AddWithValue("@SharedPostID", SqlDbType.Int).Value = SharedPostID;
                        else
                            command.Parameters.AddWithValue("@SharedPostID", SqlDbType.Int).Value = SharedPostID;
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
        public static bool GetMessageByID(int MessageID,ref int SentByMemberID,ref string Message,ref int GroupID,
            ref DateTime DateOfCreation,ref int ReplyToMessageID,ref string ImagePath,ref int SharedPostID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetGroupMessageInfoByID", connection))
                    {
                        connection.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MessageID", SqlDbType.Int).Value = MessageID;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                SentByMemberID = (int)reader["SentByMemberID"];
                                Message = (string)reader["Message"];
                                GroupID = (int)reader["GroupID"];
                                DateOfCreation = (DateTime)reader["DateOfCreation"];
                                if (reader["ReplyToMessageID"] != System.DBNull.Value)
                                    ReplyToMessageID = (int)reader["ReplyToMessageID"];
                                else
                                    ReplyToMessageID = -1;
                                if (reader["ImagePath"] != System.DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";
                                if (reader["SharedPostID"] != System.DBNull.Value)
                                    SharedPostID = (int)reader["SharedPostID"];
                                else
                                    SharedPostID = -1;
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
