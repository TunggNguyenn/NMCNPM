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
    /// Interaction logic for UpdateSaleGoodsWindow.xaml
    /// </summary>
    public partial class UpdateSaleGoodsWindow : Window
    {
        Good tempUpdateSaleGoods = new Good();
        BUS_Goods busGoods = new BUS_Goods();
        BUS_Sale busSale = new BUS_Sale();

        public UpdateSaleGoodsWindow(Good updateSaleGoods)
        {
            InitializeComponent();

            tempUpdateSaleGoods = updateSaleGoods;

            goodsCodeTextBlock.Text = updateSaleGoods.GoodsCode;
            goodsNameTextBlock.Text = updateSaleGoods.GoodsName;
            brandTextBlock.Text = $"{updateSaleGoods.ID_Brand}";
            importDateTextBlock.Text = $"{updateSaleGoods.Import_Date}";
            priceTextBlock.Text = $"{updateSaleGoods.Price.Value}";
            saleCmb.SelectedIndex = updateSaleGoods.ID_Sale.Value - 1;
            saleCmb.ItemsSource = busSale.GetAllSales();
            picture.Source = new BitmapImage(new Uri(updateSaleGoods.Picture, UriKind.RelativeOrAbsolute));
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            var ValidationWindowScreen = new ValidationWindow("EXIT");

            if (ValidationWindowScreen.ShowDialog() == true)
            {
                this.DialogResult = false;
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            var ValidationWindowScreen = new ValidationWindow("UPDATE THIS SALE");

            if (ValidationWindowScreen.ShowDialog() == true)
            {
                tempUpdateSaleGoods.ID_Sale = saleCmb.SelectedIndex + 1;

                busGoods.UpdateSaleGoods(tempUpdateSaleGoods);

                this.DialogResult = true;
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            var ValidationWindowScreen = new ValidationWindow("DELETE THIS SALE");

            if (ValidationWindowScreen.ShowDialog() == true)
            {
                tempUpdateSaleGoods.ID_Sale = 1;

                busGoods.DeleteSaleGoods(tempUpdateSaleGoods);

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
            var ValidationWindowScreen = new ValidationWindow("CANCEL");

            if (ValidationWindowScreen.ShowDialog() == true)
            {
                this.DialogResult = false;
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
