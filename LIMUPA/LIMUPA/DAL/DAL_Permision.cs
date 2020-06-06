using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMUPA.DAL
{
    class DAL_Permision: DBConect
    {
        public List<Permission> GetAllPermisions()
        {
            return db.Permissions.ToList();
        }

        public Permission GetPermissionById(int id)
        {
            return db.Permissions.Find(id);
        }
    }
}
