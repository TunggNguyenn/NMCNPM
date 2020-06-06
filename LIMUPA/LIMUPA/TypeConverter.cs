using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace LIMUPA
{
    class TypeConverter : IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, CultureInfo culture)
        {
            int typeINT = (int)value;

            BUS.BUS_Type busType = new BUS.BUS_Type();

            for (int i = 0; i < busType.GetAllTypes().Count; i++)
            {
                if (typeINT == busType.GetAllTypes()[i].ID)
                {
                    return busType.GetAllTypes()[i].TypeName + $" ({typeINT})";
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
