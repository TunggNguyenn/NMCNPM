using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace LIMUPA
{
    class ColorConverter : IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, CultureInfo culture)
        {
            int colorINT = (int)value;

            BUS.BUS_Color busColor = new BUS.BUS_Color();

            for (int i = 0; i < busColor.GetAllColors().Count; i++)
            {
                if (colorINT == busColor.GetAllColors()[i].ID)
                {
                    return busColor.GetAllColors()[i].ColorName + $" ({colorINT})";
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
