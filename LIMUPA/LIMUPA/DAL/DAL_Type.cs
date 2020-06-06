using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMUPA.DAL
{
    class DAL_Type: DBConect
    {
        public List<Type> GetAllTypes()
        {
            return db.Types.ToList();
        }
    }
}
