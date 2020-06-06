using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace LIMUPA
{
    class SizeConverter : IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, CultureInfo culture)
        {
            int sizeINT = (int)value;

            BUS.BUS_Size busSize = new BUS.BUS_Size();

            for (int i = 0; i < busSize.GetAllSizes().Count; i++)
            {
                if (sizeINT == busSize.GetAllSizes()[i].ID)
                {
                    return busSize.GetAllSizes()[i].SizeName + $" ({sizeINT})";
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
