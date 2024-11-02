using System.Data.SqlClient;
using System.Data;
using System;
using System.Runtime.CompilerServices;

namespace TelegramDataAccessLayer
{
    public class clsGroupData
    {
        public static int AddNewGroup(int CreatedByUserID,string GroupName,bool GroupType,string GroupImagePath)
        {
            int GroupID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_AddNewGroup", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CreatedByUserID", SqlDbType.Int).Value = CreatedByUserID;
                        command.Parameters.AddWithValue("@GroupName", SqlDbType.NVarChar).Value = GroupName;
                        command.Parameters.AddWithValue("@GroupType", SqlDbType.Bit).Value = GroupType;
                        if (GroupImagePath != null && GroupImagePath != "")
                            command.Parameters.AddWithValue("@GroupImagePath", SqlDbType.NVarChar).Value = GroupImagePath;
                        else
                            command.Parameters.AddWithValue("@GroupImagePath", SqlDbType.NVarChar).Value = System.DBNull.Value;
                        SqlParameter OutputIDparam = new SqlParameter("@NewGroupID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(OutputIDparam);
                        connection.Open();
                        command.ExecuteNonQuery();
                        GroupID = (int)command.Parameters["@NewGroupID"].Value;
                    }
                }
                return GroupID;
            }
            catch(Exception ex)
            {
                return -1;
            }

        }
        public static bool UpdateGroup(int GroupID,int CreatedByUserID,string GroupName,bool GroupType,string GroupImagePath)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_UpdateGroup", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@GroupID", SqlDbType.Int).Value = GroupID;
                        command.Parameters.AddWithValue("@CreatedByUserID", SqlDbType.Int).Value = CreatedByUserID;
                        command.Parameters.AddWithValue("@GroupName", SqlDbType.NVarChar).Value = GroupName;
                        command.Parameters.AddWithValue("@GroupType", SqlDbType.Bit).Value = GroupType;
                        if (GroupImagePath != null && GroupImagePath != "")
                            command.Parameters.AddWithValue("@GroupImagePath", SqlDbType.NVarChar).Value = GroupImagePath;
                        else
                            command.Parameters.AddWithValue("@GroupImagePath", SqlDbType.NVarChar).Value = System.DBNull.Value;
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
        public static bool DeleteGroup(int GroupID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_DeleteGroupByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@GroupID", SqlDbType.Int).Value = GroupID;
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
        public static DataTable GetUserEntities(int UserID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetCurrentUserEntities", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = UserID;
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
        public static DataTable GetGroupMessages(int GroupID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetGroupMessages", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("GroupID", SqlDbType.Int).Value = GroupID;
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
        public static bool GetGroupInfoByID(int GroupID,ref int CreatedByUserID,ref string GroupName,ref bool GroupType,ref string GroupImagePath)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetGroupInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@GroupID", SqlDbType.Int).Value = GroupID;
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                GroupName = (string)reader["GroupName"];
                                GroupType = (bool)reader["GroupType"];
                                if (reader["GroupImagePath"] != System.DBNull.Value)
                                    GroupImagePath = (string)reader["GroupImagePath"];
                                else
                                    GroupImagePath = "";
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
        public static int GetGroupMembersCount(int GroupID)
        {
            int Count = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("Select dbo.GetGroupMembersCount(@GroupID)", connection))
                    {
                        command.Parameters.AddWithValue("@GroupID", SqlDbType.Int).Value = GroupID;
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
    }
}
