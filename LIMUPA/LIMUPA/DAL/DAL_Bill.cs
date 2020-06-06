using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMUPA.DAL
{
    class DAL_Bill: DBConect
    {
        public List<Bill> GetAllBills()
        {
            return db.Bills.ToList();
        }

        public void AddBill(Bill info)
        {
            db.Bills.Add(info);
            db.SaveChanges();
        }
    }
}
