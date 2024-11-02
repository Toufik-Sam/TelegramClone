using System.Data.SqlClient;
using System.Data;
using System;
namespace TelegramDataAccessLayer
{
    public class clsChannelSubscribersData
    {
        public static int AddNewChannelSubscriber(int UserID, int ChannelID,bool IsAdmin,bool IsDeleted)
        {
            int MemberID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_AddNewChannelSubscriberInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = UserID;
                        command.Parameters.AddWithValue("@ChannelID", SqlDbType.Int).Value = ChannelID;
                        command.Parameters.AddWithValue("@IsAdmin", SqlDbType.Bit).Value = IsAdmin;
                        command.Parameters.AddWithValue("@IsDeleted", SqlDbType.Bit).Value = IsDeleted;
                        SqlParameter OutputIDparam = new SqlParameter("@NewMemberID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(OutputIDparam);
                        connection.Open();
                        command.ExecuteNonQuery();
                        MemberID = (int)command.Parameters["@NewMemberID"].Value;
                    }
                }
                return MemberID;
            }
            catch(Exception ex)
            {
                return -1;
            }

        }   
        public static bool UpdateChannelSubscriber(int SubscriberID, int UserID, int ChannelID,bool IsAdmin,bool IsDeleted)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_UpdateChannelSubscriberInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SubscriberID", SqlDbType.Int).Value = SubscriberID;
                        command.Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = UserID;
                        command.Parameters.AddWithValue("@ChannelID", SqlDbType.Int).Value = ChannelID;
                        command.Parameters.AddWithValue("@IsAdmin", SqlDbType.Bit).Value = IsAdmin;
                        command.Parameters.AddWithValue("@IsDeleted", SqlDbType.Bit).Value = IsDeleted;
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
        public static int GetSubscriberIDByUserID(int UserID,int ChannelID)
        {
            int MemberID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("Select dbo.GetSubscriberIDByUserID(@UserID,@ChannelID)", connection))
                    {
                        command.Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = UserID;
                        command.Parameters.AddWithValue("@ChannelID", SqlDbType.Int).Value = ChannelID;
                        connection.Open();
                        if (command.ExecuteScalar() != System.DBNull.Value)
                            MemberID = (int)command.ExecuteScalar();
                        else
                            MemberID = -1;
                    }
                }
                return MemberID;
            }
            catch(Exception ex)
            {
                return -1;
            }

        }
        public static bool GetSubscriberInfoByID(int SubscriberID,ref int UserID,ref int ChannelID,ref bool IsAdmin,ref bool IsDeleted)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetSubscriberInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SubscriberID", SqlDbType.Int).Value = SubscriberID;
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UserID = (int)reader["UserID"];
                                ChannelID = (int)reader["ChannelID"];
                                IsAdmin = (bool)reader["IsAdmin"];
                                IsDeleted = (bool)reader["IsDeleted"];
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
        public static bool IsCurrentUserAdmin(int UserID,int ChannelID)
        {
            bool IsAdmin = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("Select dbo.IsUserAdminInChannel(@UserID,@ChannelID)", connection))
                    {
                        command.Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = UserID;
                        command.Parameters.AddWithValue("@ChannelID", SqlDbType.Int).Value = ChannelID;
                        connection.Open();
                        IsAdmin = (bool)command.ExecuteScalar();
                    }
                }
                return IsAdmin;
            }
            catch(Exception ex)
            {
                return true;
            }

        }
        public static bool IsCurrentUserSubscriber(int UserID,int ChannelID)
        {
            bool IsSubscriber = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("Select dbo.IsUserSubscriberInChannel(@UserID,@ChannelID)", connection))
                    {
                        command.Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = UserID;
                        command.Parameters.AddWithValue("@ChannelID", SqlDbType.Int).Value = ChannelID;
                        connection.Open();
                        IsSubscriber = (bool)command.ExecuteScalar();
                    }
                }
                return IsSubscriber;
            }
            catch(Exception ex)
            {
                return false;
            }

        }
        public static string GetSubscriberNameByID(int SubscriberID)
        {
            string SubscriberName = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("Select dbo.GetSubscriberNameByID(@SubscriberID)", connection))
                    {
                        command.Parameters.AddWithValue("@SubscriberID", SqlDbType.Int).Value = SubscriberID;
                        connection.Open();
                        if (command.ExecuteScalar() != System.DBNull.Value)
                            SubscriberName = command.ExecuteScalar().ToString();
                        else
                            SubscriberName = "";
                    }
                }
                return SubscriberName;
            }
            catch(Exception ex)
            {
                return "";
            }

        }
        public static DataTable GetChannelSubscribersChannelID(int ChannelID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("Select * From dbo.GetChannelSubscribersByChannelID(@ChannelID)", connection))
                    {
                        command.Parameters.AddWithValue("@ChannelID", SqlDbType.Int).Value = ChannelID;
                        connection.Open();
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
        public static int GetChannelSubscribersCount(int ChannelID)
        {
            int Count = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("Select dbo.GetChannelSubscribersCount(@ChannelID)", connection))
                    {
                        command.Parameters.AddWithValue("@ChannelID", SqlDbType.Int).Value = ChannelID;
                        connection.Open();
                        Count = (int)command.ExecuteScalar();
                    }
                }
                return Count;
            }
            catch(Exception ex)
            {
                return 0;
            }

        }
        public static bool DeleteSubscriberByID(int SubscriberID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_DeleteSubscriberByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SubscriberID", SqlDbType.Int).Value = SubscriberID;
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