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
using Microsoft.Win32;

namespace LIMUPA.GUI
{
    /// <summary>
    /// Interaction logic for UpdateWindows.xaml
    /// </summary>
    public partial class UpdateWindows : Window
    {
        Good UpdatedGoods = new Good();
        BUS_Goods busGoods = new BUS_Goods();
        BUS_Color busColor = new BUS_Color();
        BUS_Brand busBrand = new BUS_Brand();
        BUS_Type busType = new BUS_Type();
        BUS_Size busSize = new BUS_Size();

        public UpdateWindows(Good updatedGoods)
        {
            InitializeComponent();

            UpdatedGoods = updatedGoods;
            colorCmb.ItemsSource = busColor.GetAllColors();
            brandCmb.ItemsSource = busBrand.GetAllBrands();
            typeCmb.ItemsSource = busType.GetAllTypes();
            sizeCmb.ItemsSource = busSize.GetAllSizes();


            goodsCode.Text = updatedGoods.GoodsCode;
            goodsName.Text = updatedGoods.GoodsName;
            colorCmb.SelectedIndex = updatedGoods.Color.Value - 1;
            brandCmb.SelectedIndex = updatedGoods.Brand.Value - 1;
            sizeCmb.SelectedIndex = updatedGoods.Size.Value - 1;
            typeCmb.SelectedIndex = updatedGoods.Type.Value - 1;
            priceTextBox.Text = $"{updatedGoods.Price.Value}";
            addedPicture.Source = new BitmapImage(new Uri(updatedGoods.Picture, UriKind.RelativeOrAbsolute));
        }

        private void addPictureButton_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialogScreen = new OpenFileDialog();

            if (openFileDialogScreen.ShowDialog() == true)
            {
                //MessageBox.Show(openFileDialogScreen.FileName);

                addPictureButton.Height = 300;
                addPictureButton.Width = 300;

                addedPicture.Source = new BitmapImage(new Uri(openFileDialogScreen.FileName.ToString(), UriKind.RelativeOrAbsolute));
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            UpdatedGoods.GoodsCode = goodsCode.Text;
            UpdatedGoods.GoodsName = goodsName.Text;
            UpdatedGoods.Color = colorCmb.SelectedIndex + 1;
            UpdatedGoods.Brand = brandCmb.SelectedIndex + 1;
            UpdatedGoods.Size = sizeCmb.SelectedIndex + 1;
            UpdatedGoods.Type = typeCmb.SelectedIndex + 1;
            UpdatedGoods.Price = double.Parse(priceTextBox.Text);
            UpdatedGoods.Picture = addedPicture.Source.ToString();

            busGoods.UpdateGoods(UpdatedGoods);

            this.DialogResult = true;
            this.Close();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            busGoods.DeleteGoods(UpdatedGoods);

            this.DialogResult = true;
            this.Close();
        }
    }
}
