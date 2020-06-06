using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace LIMUPA.Converter
{
    class SaleConverter : IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, CultureInfo culture)
        {
            int saleINT = (int)value;

            BUS.BUS_Sale busSale = new BUS.BUS_Sale();
            List<Sale> sales = busSale.GetAllSales();

            for (int i = 0; i < sales.Count; i++)
            {
                if (saleINT == sales[i].ID)
                {
                    return $"Sale: {sales[i].PercentageSale} (%) + Donate: {sales[i].Donate}";
                }
            }

            return "";
        }

        public object ConvertBack(object value, System.Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
