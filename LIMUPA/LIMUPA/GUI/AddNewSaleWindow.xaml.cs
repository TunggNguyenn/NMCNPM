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

namespace LIMUPA.GUI
{
    /// <summary>
    /// Interaction logic for AddNewSaleWindow.xaml
    /// </summary>
    public partial class AddNewSaleWindow : Window
    {
        BUS_Goods busGoods = new BUS_Goods();
        ListView tempGoodsListView1 = new ListView();
        ListView tempGoodsListView2 = new ListView();
        ListView tempGoodsListView3 = new ListView();

        public AddNewSaleWindow(ListView goodsListView1, ListView goodsListView2, ListView goodsListView3)
        {
            InitializeComponent();

            tempGoodsListView1 = goodsListView1;
            tempGoodsListView2 = goodsListView2;
            tempGoodsListView3 = goodsListView3;

            nowdateDatePicker.SelectedDate = DateTime.Now.Date;
        } 

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            if (importdateDatePicker.SelectedDate > nowdateDatePicker.SelectedDate || importdateDatePicker.Text == "" || nowdateDatePicker.Text == "")
            {
                validationAccessText.Text = "Khoảng ngày không hợp lệ!";
                return;
            }
            else
            {
                var SaleItemsWindowScreen = new SaleItemsWindow(importdateDatePicker, nowdateDatePicker);

                if (SaleItemsWindowScreen.ShowDialog() == true)
                {
                    tempGoodsListView1.ItemsSource = busGoods.GetAllGoods();
                    tempGoodsListView2.ItemsSource = busGoods.GetAllGoods();

                    //Grouping goodsListView3
                    tempGoodsListView3.ItemsSource = busGoods.GetAllGoods();
                    CollectionView saleView = (CollectionView)CollectionViewSource.GetDefaultView(tempGoodsListView3.ItemsSource);
                    PropertyGroupDescription groupDescription = new PropertyGroupDescription("ID_Sale");
                    saleView.GroupDescriptions.Add(groupDescription);

                    return;
                }
                else
                {
                    return;
                }
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
