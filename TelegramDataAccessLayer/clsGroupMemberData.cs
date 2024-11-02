using System;
using System.Data;
using System.Data.SqlClient;

namespace TelegramDataAccessLayer
{
    public class clsGroupMemberData
    {
        public static int AddNewGroupMember(int UserID,int GroupID,bool IsAdmin,bool IsDeleted)
        {
            int MemberID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_AddNewGroupMemberInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = UserID;
                        command.Parameters.AddWithValue("@GroupID", SqlDbType.Int).Value = GroupID;
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
        public static bool UpdateGroupMember(int MemberID,int UserID,int GroupID,bool IsAdmin,bool IsDeleted)
        {
            int rowsAffected =0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_UpdateGroupMemberInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MemberID", SqlDbType.Int).Value = MemberID;
                        command.Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = UserID;
                        command.Parameters.AddWithValue("@GroupID", SqlDbType.Int).Value = GroupID;
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
        public static bool DeleteGroupMember(int MemberID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_DeleteGroupMember", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MemberID", SqlDbType.Int).Value = MemberID;
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
        public static int GetMemberIDByUserID(int UserID,int GroupID)
        {
            int MemberID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetMemberIBByUserID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = UserID;
                        command.Parameters.AddWithValue("@GroupID", SqlDbType.Int).Value = GroupID;
                        SqlParameter OutputIdParam = new SqlParameter("@MemberID", SqlDbType.Int)
                        { Direction = ParameterDirection.Output };
                        command.Parameters.Add(OutputIdParam);
                        connection.Open();
                        command.ExecuteNonQuery();
                        MemberID = (int)command.Parameters["@MemberID"].Value;
                    }
                }
                return MemberID;
            }
            catch(Exception ex)
            {
                return -1;
            }

        }
        public static string GetMemberImageByID(int MemberID)
        {
            string ImagePath = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetMemberImageByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MemberID", SqlDbType.Int).Value = MemberID;
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader["ImagePath"] != System.DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";
                            }
                        }
                    }
                }
                return ImagePath;
            }
            catch(Exception ex)
            {
                return "";
            }

        }
        public static string GetMemberNameByID(int MemberID)
        {
            string MemberFullName = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("Select dbo.GetMemberNameByID(@MemberID)", connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", SqlDbType.Int).Value = MemberID;
                        connection.Open();
                        if (command.ExecuteScalar() != System.DBNull.Value)
                            MemberFullName = command.ExecuteScalar().ToString();
                        else
                            MemberFullName = "";
                    }
                }
                return MemberFullName;
            }
            catch(Exception ex)
            {
                return "";
            }

        }
        public static DataTable GetGroupMembersByGroupID(int GroupID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Select * From dbo.GetGroupMembersInfoByGroupID(@GroupID)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GroupID", GroupID);
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
        public static bool IsMemberDeleted(int MemberID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_IsMemberDeleted", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MemberID", SqlDbType.Int).Value = MemberID;
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IsFound = (bool)reader["IsDelete"];
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
