using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIMUPA.DAL;

namespace LIMUPA.BUS
{
    class BUS_Expenses
    {
        DAL_Expenses dalExpenses = new DAL_Expenses();

        public List<Expens> GetAllExpenses()
        {
            return dalExpenses.GetAllExpenses();
        }

        public void AddExpenses(Expens info)
        {
            dalExpenses.AddExpenses(info);
        }

        public void DeleteExpenses(Expens info)
        {
            dalExpenses.DeleteExpenses(info);
        }

        public void UpdateExpenses(Expens info)
        {
            dalExpenses.UpdateExpenses(info);
        }

        public double GetTotalExpensesByMonth(int month, int year)
        {
            List<Expens> expenses = GetAllExpenses();
            double total = 0;

            for (int i = 0; i < expenses.Count; i++)
            {
                if(expenses[i].DateTime.Value.Month == month && expenses[i].DateTime.Value.Year == year)
                {
                    total += (double)expenses[i].Total;
                }
            }

            return total;
        }

        public double GetTotalExpensesByYear(int year)
        {
            List<Expens> expenses = GetAllExpenses();
            double total = 0;

            for (int i = 0; i < expenses.Count; i++)
            {
                if (expenses[i].DateTime.Value.Year == year)
                {
                    total += (double)expenses[i].Total;
                }
            }

            return total;
        }
    }
}
