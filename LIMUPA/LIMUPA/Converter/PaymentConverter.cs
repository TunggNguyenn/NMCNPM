using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace LIMUPA.Converter
{
    class PaymentConverter : IMultiValueConverter
    {
        public object Convert(object[] values, System.Type targetType, object parameter, CultureInfo culture)
        {
            string cashStr = (string)values[0];

            if(cashStr == "")
            {
                cashStr = "0";
            }

            double cash = double.Parse((string)cashStr);
            double total = double.Parse((string)values[1]);

            double change = cash - total;
            if(change >= 0)
            {
                return $"{change}";
            }

            return "0";
        }

        public object[] ConvertBack(object value, System.Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
