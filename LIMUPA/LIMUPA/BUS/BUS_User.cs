using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIMUPA.DAL;

namespace LIMUPA.BUS
{
    class BUS_User
    {
        DAL_User dalUser = new DAL_User();

        public List<User> GetAllUsers()
        {
            return dalUser.GetAllUsers();
        }

        public int GetID(string username, string password)
        {
            List<User> users = dalUser.GetAllUsers();

            for(int i = 0; i < users.Count; i++)
            {
                if(users[i].UserName == username && users[i].PassWord == password)
                {
                    return users[i].ID;
                }
            }

            return -1;
        }

        public string GetUserNameByUserID(int userID)
        {
            List<User> users = dalUser.GetAllUsers();

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].ID == userID)
                {
                    return users[i].NameUser;
                }
            }

            return "";
        }
    }
}
