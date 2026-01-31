using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechStoreApp_Core_.Models;
namespace TechStoreDataTier.Interfaces
{
    internal interface IPermissionRepository
    {
        Permission GetPermissionById(int id);
        List<Permission> GetAllPermissions();
        Permission GetPermissionByCode(string name);

        bool AddPermission(Permission permission);
        Permission UpdatePermissionTitle(Permission permission);

    }
}
