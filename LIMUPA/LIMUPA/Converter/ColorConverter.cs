using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace LIMUPA.Converter
{
    class ColorConverter : IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, CultureInfo culture)
        {
            int colorINT = (int)value;

            BUS.BUS_Color busColor = new BUS.BUS_Color();
            List<Color> colors = busColor.GetAllColors();

            for (int i = 0; i < colors.Count; i++)
            {
                if (colorINT == colors[i].ID)
                {
                    return colors[i].ColorName;
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
