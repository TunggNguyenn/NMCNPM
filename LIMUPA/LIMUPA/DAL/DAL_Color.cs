using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMUPA.DAL
{
    class DAL_Color: DBConect
    {
        public List<Color> GetAllColors()
        {
            return db.Colors.ToList();
        }
    }
}
