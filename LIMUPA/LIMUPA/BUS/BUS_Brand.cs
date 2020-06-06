using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIMUPA.DAL;

namespace LIMUPA.BUS
{
    class BUS_Brand
    {
        DAL_Brand dalBrand = new DAL_Brand();

        public List<Brand> GetAllBrands()
        {
            return dalBrand.GetAllBrands();
        }
    }
}
