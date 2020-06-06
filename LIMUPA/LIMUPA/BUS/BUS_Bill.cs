using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIMUPA.DAL;

namespace LIMUPA.BUS
{
    class BUS_Bill
    {
        DAL_Bill dalBill = new DAL_Bill();

        public List<Bill> GetAllBills()
        {
            return dalBill.GetAllBills();
        }

        public string GetNextBillCode()
        {
            int id = 0;

            List<Bill> bills = dalBill.GetAllBills();

            if (bills.Count != 0)
            {
                id = int.Parse(bills[bills.Count - 1].BillCode) + 1;
            }

            return $"{id}";
        }


        public void AddBill(Bill info)
        {
            dalBill.AddBill(info);
        }

        public double GetTotalByDateTime(DateTime dayRevenue)
        {
            List<Bill> bills = GetAllBills();
            double total = 0;

            for(int i = 0; i < bills.Count; i++)
            {
                if (i == 0)
                {
                    if(bills[i].DateTime == dayRevenue)
                    {
                        total += (double)bills[i].Total;
                        continue;
                    }
                }

                if (bills[i].DateTime == dayRevenue && bills[i - 1].BillCode != bills[i].BillCode)
                {
                    total += (double)bills[i].Total;
                }
            }

            return total;
        }

        public double GetTotalBillsByMonth(int month, int year)
        {
            List<Bill> bills = GetAllBills();
            double total = 0;

            for (int i = 0; i < bills.Count; i++)
            {
                if (i == 0)
                {
                    if (bills[i].DateTime.Value.Month == month && bills[i].DateTime.Value.Year == year)
                    {
                        total += (double)bills[i].Total;
                        continue;
                    }
                }

                if (bills[i].DateTime.Value.Month == month && bills[i].DateTime.Value.Year == year && bills[i - 1].BillCode != bills[i].BillCode)
                {
                    total += (double)bills[i].Total;
                }
            }

            return total;
        }

        public double GetTotalBillsByYear(int year)
        {
            List<Bill> bills = GetAllBills();
            double total = 0;

            for (int i = 0; i < bills.Count; i++)
            {
                if (i == 0)
                {
                    if (bills[i].DateTime.Value.Year == year)
                    {
                        total += (double)bills[i].Total;
                        continue;
                    }
                }

                if (bills[i].DateTime.Value.Year == year && bills[i - 1].BillCode != bills[i].BillCode)
                {
                    total += (double)bills[i].Total;
                }
            }

            return total;
        }

        public List<Bill> GetBills()
        {
            List<Bill> bills = GetAllBills();

            for(int i = 0; i < bills.Count; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                else
                {
                    if(bills[i].BillCode == bills[i - 1].BillCode)
                    {
                        bills.RemoveAt(i);
                        i--;
                    }
                }
            }

            return bills;
        }

        public List<int> GetID_GoodsByBillCode(string billCode)
        {
            List<Bill> bills = GetAllBills();
            List<int> id_goodsList = new List<int>();

            for (int i = 0; i < bills.Count; i++)
            {
                if(bills[i].BillCode == billCode)
                {
                    id_goodsList.Add(bills[i].ID_Goods.Value);
                }
            }

            return id_goodsList;
        }
    }
}
