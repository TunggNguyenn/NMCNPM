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
using System.Windows.Shapes;
using LIMUPA.BUS;
using LIMUPA.Converter;

namespace LIMUPA.GUI
{
    /// <summary>
    /// Interaction logic for ViewBillWindow.xaml
    /// </summary>
    public partial class ViewBillWindow : Window
    {
        BUS_Bill busBill = new BUS_Bill();
        BUS_Goods busGoods = new BUS_Goods();
        UserConverter userConverter = new UserConverter();

        public ViewBillWindow()
        {
            InitializeComponent();

            billListView.ItemsSource = busBill.GetBills();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void billListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedBill = billListView.SelectedItem as Bill;

            List<Good> goodsOfSelectedBill = new List<Good>();

            for(int i = 0; i < busBill.GetID_GoodsByBillCode(selectedBill.BillCode).Count; i++)
            {
                goodsOfSelectedBill.Add(busGoods.GetGoodsById(busBill.GetID_GoodsByBillCode(selectedBill.BillCode)[i]));
            }

            var PaymentWindowScreen = new PaymentWindow(1, selectedBill.BillCode, selectedBill.CustomerName, selectedBill.CustomerPhoneNumber, selectedBill.CustomerAddress,
              userConverter.Convert(selectedBill.ID_Staff.Value, null, null, null) as string, goodsOfSelectedBill, selectedBill.Total.ToString());

            if (PaymentWindowScreen.ShowDialog() == true)
            {
                return;
            }
            else
            {
                return;
            }
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            if (searchTextBox.Text == "")
            {
                return;
            }

            List<Bill> bills= billListView.ItemsSource as List<Bill>;

            for(int i = 0; i < bills.Count; i++)
            {
                if(bills[i].BillCode == searchTextBox.Text)
                {
                    List<Good> goodsOfSelectedBill = new List<Good>();

                    for (int j = 0; j < busBill.GetID_GoodsByBillCode(bills[i].BillCode).Count; j++)
                    {
                        goodsOfSelectedBill.Add(busGoods.GetGoodsById(busBill.GetID_GoodsByBillCode(bills[i].BillCode)[j]));
                    }

                    var PaymentWindowScreen = new PaymentWindow(1, bills[i].BillCode, bills[i].CustomerName, bills[i].CustomerPhoneNumber, bills[i].CustomerAddress,
                      userConverter.Convert(bills[i].ID_Staff.Value, null, null, null) as string, goodsOfSelectedBill, bills[i].Total.ToString());

                    if (PaymentWindowScreen.ShowDialog() == true)
                    {
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
            }

            var AnnouncementWindowScreen = new AnnouncementWindow("DON'T FIND THIS CODE... PLEASE TYPE AGAIN!");

            if (AnnouncementWindowScreen.ShowDialog() == true)
            {
                return;
            }
            else
            {
                return;
            }
        }
    }
}
