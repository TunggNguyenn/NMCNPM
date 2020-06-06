using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace LIMUPA.Converter
{
    class PermissionNameConverter : IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, CultureInfo culture)
        {
            int userID = (int)value;

            BUS.BUS_PermisionRelationship busPermissionRelationship = new BUS.BUS_PermisionRelationship();
            BUS.BUS_Permision busPermission = new BUS.BUS_Permision();

            int permissionrelationshipID = busPermissionRelationship.GetPermisionIDByIDUserID(userID);
            Permission permission = busPermission.GetPermissionById(permissionrelationshipID);

            if (permission == null)
            {
                return "Nhân viên";
            }

            return permission.NamePermission.ToString();

        }

        public object ConvertBack(object value, System.Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
