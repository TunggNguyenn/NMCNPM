using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIMUPA.DAL;

namespace LIMUPA.BUS
{
    class BUS_PermisionRelationship
    {
        DAL_PermisionRelationship dalPermisionRelationship = new DAL_PermisionRelationship();

        public int GetPermisionIDByIDUserID(int userID)
        {
            List<PermisionRelationship> permisionrelationships = dalPermisionRelationship.GetAllPermisionRelationships();

            for(int i = 0; i < permisionrelationships.Count; i++)
            {
                if (permisionrelationships[i].ID_User == userID)
                {
                    return permisionrelationships[i].ID_Permission;
                }
            }

            return -1;
        }
    }
}
