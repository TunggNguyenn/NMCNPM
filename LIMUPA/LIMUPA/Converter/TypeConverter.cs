using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace LIMUPA.Converter
{
    class TypeConverter : IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, CultureInfo culture)
        {
            int typeINT = (int)value;

            BUS.BUS_Type busType = new BUS.BUS_Type();
            List<Type> types = busType.GetAllTypes();

            for (int i = 0; i < types.Count; i++)
            {
                if (typeINT == types[i].ID)
                {
                    return types[i].TypeName;
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
