using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for SaleItemsWindow.xaml
    /// </summary>
    public partial class SaleItemsWindow : Window
    {
        BUS_Goods busGoods = new BUS_Goods();
        DateTime importDateTime = new DateTime();
        DateTime nowDateTime = new DateTime();

        public SaleItemsWindow(DatePicker importDate, DatePicker nowDate)
        {
            InitializeComponent();

            importDateTime = (DateTime)importDate.SelectedDate;
            nowDateTime = (DateTime)nowDate.SelectedDate;
            importdateTextBlock.Text = importDate.Text;
            //nowdateTextBlock.Text = DateTime.Now.Date.ToShortDateString();  //
            nowdateTextBlock.Text = nowDate.SelectedDate.ToString();


            goodsListView.ItemsSource = busGoods.GetGoodsByImportDate((DateTime)importDate.SelectedDate, (DateTime)nowDate.SelectedDate).ToList();

        }


        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void saleMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var saledGoodsIndex = goodsListView.SelectedIndex;

            if (saledGoodsIndex == -1)
            {
                return;
            }

            var SaleWindowScreen = new SaleWindow((Good)goodsListView.SelectedItem);

            if (SaleWindowScreen.ShowDialog() == true)
            {
                goodsListView.ItemsSource = busGoods.GetGoodsByImportDate(importDateTime, nowDateTime);

                return;
            }
            else
            {
                return;
            }
        }

    }
}
