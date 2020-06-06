using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIMUPA.DAL;

namespace LIMUPA.BUS
{
    class BUS_Color
    {
        DAL_Color dalColor = new DAL_Color();

        public List<Color> GetAllColors()
        {
            return dalColor.GetAllColors();
        }
    }
}
