using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace LIMUPA.Converter
{
    class SizeConverter : IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, CultureInfo culture)
        {
            int sizeINT = (int)value;

            BUS.BUS_Size busSize = new BUS.BUS_Size();
            List<Size> sizes = busSize.GetAllSizes();

            for (int i = 0; i < sizes.Count; i++)
            {
                if (sizeINT == sizes[i].ID)
                {
                    return sizes[i].SizeName;
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
