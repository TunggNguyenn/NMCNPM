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
    /// Interaction logic for SaleWindow.xaml
    /// </summary>
    public partial class SaleWindow : Window
    {
        Good tempSaleGoods = new Good();
        BUS_Sale busSale = new BUS_Sale();
        BUS_Goods busGoods = new BUS_Goods();


        public SaleWindow(Good saleGoods)
        {
            InitializeComponent();

            tempSaleGoods = saleGoods;

            saleCmb.ItemsSource = busSale.GetAllSales();
            saleCmb.SelectedIndex = saleGoods.ID_Sale.Value - 1;
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            var ValidationWindowScreen = new ValidationWindow("SALE THIS ITEM");

            if (ValidationWindowScreen.ShowDialog() == true)
            {
                tempSaleGoods.ID_Sale = saleCmb.SelectedIndex + 1;
                busGoods.UpdateSaleGoods(tempSaleGoods);


                this.DialogResult = true;
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

    }
}
