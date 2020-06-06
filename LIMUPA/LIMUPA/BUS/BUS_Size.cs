using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIMUPA.DAL;

namespace LIMUPA.BUS
{
    class BUS_Size
    {
        DAL_Size dalSize = new DAL_Size();

        public List<Size> GetAllSizes()
        {
            return dalSize.GetAllSizes();
        }
    }
}
