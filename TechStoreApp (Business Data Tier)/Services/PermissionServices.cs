using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechStoreApp_Core_.Models;
using TechStoreDataTier.Repositories;

namespace TechStoreApp__Business_Data_Tier_.Services
{
    public class PermissionServices
    {
       public static List<Permission> GetAllPermissions()
       {
            PermissionRepository permissionRepository = new PermissionRepository();

            return permissionRepository.GetAllPermissions();
       } 

        public static Permission GetPermissionById(int id)
        {
            PermissionRepository permissionRepository = new PermissionRepository();
            return permissionRepository.GetPermissionById(id);
        }
    }
}
