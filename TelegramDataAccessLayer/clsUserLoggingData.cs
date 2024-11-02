using System;
using System.Data.SqlClient;
using System.Data;
namespace TelegramDataAccessLayer
{
    public class clsUserLoggingData
    {
        public static int AddNewLogID(int UserID,int EntityID,DateTime LogOutDate,bool IsGroup,bool IsChannel)
        {
            int LogID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_AddNewUserLog", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = UserID;
                        command.Parameters.AddWithValue("@EntityID", SqlDbType.Int).Value = EntityID;
                        command.Parameters.AddWithValue("@LogOutDate", SqlDbType.DateTime).Value = LogOutDate;
                        command.Parameters.AddWithValue("@IsGroup", SqlDbType.Bit).Value = IsGroup;
                        command.Parameters.AddWithValue("@IsChannel", SqlDbType.Bit).Value = IsChannel;

                        SqlParameter OutputIDparam = new SqlParameter("@NewLogID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(OutputIDparam);
                        connection.Open();
                        command.ExecuteNonQuery();
                        LogID = (int)command.Parameters["@NewLogID"].Value;
                    }
                }
                return LogID;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public static bool UpdateLogID(int LogID,int UserID, int EntityID,DateTime LogOutDate, bool IsGroup,bool IsChannel)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_UpdateUserLog", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@LogID", SqlDbType.Int).Value = LogID;
                        command.Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = UserID;
                        command.Parameters.AddWithValue("@EntityID", SqlDbType.Int).Value = EntityID;
                        command.Parameters.AddWithValue("@LogOutDate", SqlDbType.DateTime).Value = LogOutDate;
                        command.Parameters.AddWithValue("@IsGroup", SqlDbType.Bit).Value = IsGroup;
                        command.Parameters.AddWithValue("@IsChannel", SqlDbType.Bit).Value = IsChannel;
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
