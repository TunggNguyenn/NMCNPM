using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMUPA.DAL
{
    class DAL_Expenses: DBConect
    {
        public List<Expens> GetAllExpenses()
        {
            return db.Expenses.ToList();
        }

        public void AddExpenses(Expens info)
        {
            db.Expenses.Add(info);
            db.SaveChanges();
        }

        public void DeleteExpenses(Expens info)
        {
            db.Expenses.Remove(info);
            db.SaveChanges();
        }

        public void UpdateExpenses(Expens info)
        {
            //Xác định đối tượng cần cập nhật
            var updatedExpenses = db.Expenses.Find(info.ID);

            //Thay đổi các thông tin mới
            updatedExpenses.Electric = info.Electric;
            updatedExpenses.Water = info.Water;
            updatedExpenses.Rent_Premises = info.Rent_Premises;
            updatedExpenses.DateTime = info.DateTime;
            updatedExpenses.SalaryStaff = info.SalaryStaff;
            updatedExpenses.Goods = info.Goods;
            updatedExpenses.Total = info.Total;

            db.SaveChanges();
        }
    }
}
