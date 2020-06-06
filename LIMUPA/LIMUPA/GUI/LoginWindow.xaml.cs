using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LIMUPA.BUS;

namespace LIMUPA.GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        BUS_User busUser = new BUS_User();
        BUS_PermisionRelationship busPermisionRelationship = new BUS_PermisionRelationship();
        BUS_Permision busPermision = new BUS_Permision();

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            var ValidationWindowScreen = new ValidationWindow("CANCEL");

            if (ValidationWindowScreen.ShowDialog() == true)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            var username = usernameTextBox.Text;
            var password = passwordBox.Password;

            if(username==""|| password == "")
            {
                stateLabel.Content = "Vui lòng nhập đầy đủ USERNAME và PASSWORD!";
                return;
            }

            int userID = busUser.GetID(username, password);

            if (userID == -1)
            {
                stateLabel.Content = "Tài khoản không hợp lệ!";
            }
            else
            {
                int permisionID = busPermisionRelationship.GetPermisionIDByIDUserID(userID);

                if (permisionID == -1)
                {
                    stateLabel.Content = "Nhân viên chưa được cấp quyền";
                }
                else
                {
                    string permisionName = busPermision.GetNamePermision(permisionID);

                    var HomeWindowsScreen = new HomeWindow(userID, permisionName);
                    this.Hide();
                    if (HomeWindowsScreen.ShowDialog() == true)
                    {
                        this.Show();
                    }
                    else
                    {
                        this.Close();
                    }

                }
            }
        }
    }
}
