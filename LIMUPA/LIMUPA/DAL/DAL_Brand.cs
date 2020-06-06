using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMUPA.DAL
{
    class DAL_Brand: DBConect
    {
        public List<Brand> GetAllBrands()
        {
            return db.Brands.ToList();
        }
    }
}
