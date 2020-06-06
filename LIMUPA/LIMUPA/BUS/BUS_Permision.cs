using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIMUPA.DAL;

namespace LIMUPA.BUS
{
    class BUS_Permision
    {
        DAL_Permision dalPermision = new DAL_Permision();

        public string GetNamePermision(int permisionID)
        {
            List<Permission> permisions = dalPermision.GetAllPermisions();

            for(int i = 0; i < permisions.Count; i++)
            {
                if(permisions[i].ID == permisionID)
                {
                    return permisions[i].NamePermission;
                }
            }

            return "";
        }

        public Permission GetPermissionById(int id)
        {
            return dalPermision.GetPermissionById(id);
        }
    }
}
