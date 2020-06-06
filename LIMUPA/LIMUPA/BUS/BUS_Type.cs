using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIMUPA.DAL;

namespace LIMUPA.BUS
{
    class BUS_Type
    {
        DAL_Type dalType = new DAL_Type();

        public List<Type> GetAllTypes()
        {
            return dalType.GetAllTypes();
        }
    }
}
