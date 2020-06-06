using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMUPA.DAL
{
    class DAL_User: DBConect
    {
        public List<User> GetAllUsers()
        {
            return db.Users.ToList();
        }
    }
}
