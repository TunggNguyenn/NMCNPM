using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMUPA.DAL
{
    class DAL_PermisionRelationship: DBConect
    {
        public List<PermisionRelationship> GetAllPermisionRelationships()
        {
            return db.PermisionRelationships.ToList();
        }
    }
}
