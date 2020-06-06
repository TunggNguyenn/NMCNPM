using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIMUPA.DAL;

namespace LIMUPA.BUS
{
    class BUS_Sale
    {
        DAL_Sale dalSale = new DAL_Sale();

        public List<Sale> GetAllSales()
        {
            return dalSale.GetAllSales();
        }

        public Sale GetSaleByID(int id)
        {
            return dalSale.GetSaleByID(id);
        }

        public int GetPercentageByIDSale(int id)
        {
            Sale sale = GetSaleByID(id);

            return sale.PercentageSale.Value;
        }
    }
}
