using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechStoreApp_Core_.Models;
using TechStoreDataTier.Interfaces;
namespace TechStoreDataTier.Repositories
{
    public class PermissionRepository : IPermissionRepository
    {
        //iNSERT
        public bool AddPermission(Permission permission)
        {
            throw new NotImplementedException();
        }

        //Get
        public List<Permission> GetAllPermissions()
        {
            List<Permission> permissions = new List<Permission>();
            try
            {
                string query = "SELECT * FROM Permissions";

                using (SqlConnection conn = new SqlConnection(DataBaseSettings.ConnectionString))                
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        permissions.Add(new Permission((int)reader["Id"], reader["PermissionName"].ToString(), (int)reader["PermissionCode"]));
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error in GetAllPermissions: " + ex.Message);                
            }
            return permissions;
        }

        public Permission GetPermissionByCode(string name)
        {
            throw new NotImplementedException();
        }

        public Permission GetPermissionById(int id)
        {
            Permission permission = null;
            try
            {
                string query = "SELECT * FROM Permissions WHERE Id = @Id";

                using (SqlConnection conn = new SqlConnection(DataBaseSettings.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        permission = new Permission((int)reader["Id"], reader["PermissionName"].ToString(), (int)reader["PermissionCode"]);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error in GetPermissionById: " + ex.Message);
            }

            return permission;
        }

        //Update
        public Permission UpdatePermissionTitle(Permission permission)
        {
            throw new NotImplementedException();
        }
    }
}
