using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace LIMUPA.Converter
{
    class BrandConverter : IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, CultureInfo culture)
        {
            int brandINT = (int)value;

            BUS.BUS_Brand busBrand = new BUS.BUS_Brand();
            List<Brand> brands = busBrand.GetAllBrands();

            for (int i = 0; i < brands.Count; i++)
            {
                if (brandINT == brands[i].ID)
                {
                    return brands[i].BrandName;
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
