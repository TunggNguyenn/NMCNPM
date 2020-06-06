using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace LIMUPA
{
    class BrandConverter : IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, CultureInfo culture)
        {
            int brandINT = (int)value;

            BUS.BUS_Brand busBrand = new BUS.BUS_Brand();

            for (int i = 0; i < busBrand.GetAllBrands().Count; i++)
            {
                if (brandINT == busBrand.GetAllBrands()[i].ID)
                {
                    return busBrand.GetAllBrands()[i].BrandName + $" ({brandINT})";
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
