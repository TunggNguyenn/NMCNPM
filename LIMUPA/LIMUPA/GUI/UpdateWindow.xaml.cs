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
    /// Interaction logic for UpdateWindow.xaml
    /// </summary>
    public partial class UpdateWindow : Window
    {
        Good tempUpdatedGoods = new Good();
        BUS_Goods busGoods = new BUS_Goods();
        BUS_Color busColor = new BUS_Color();
        BUS_Brand busBrand = new BUS_Brand();
        BUS_Type busType = new BUS_Type();
        BUS_Size busSize = new BUS_Size();

        public UpdateWindow(Good updatedGoods)
        {
            InitializeComponent();

            tempUpdatedGoods = updatedGoods;
            colorCmb.ItemsSource = busColor.GetAllColors();
            brandCmb.ItemsSource = busBrand.GetAllBrands();
            typeCmb.ItemsSource = busType.GetAllTypes();
            sizeCmb.ItemsSource = busSize.GetAllSizes();


            goodsCodeTextBox.Text = updatedGoods.GoodsCode;
            goodsNameTextBox.Text = updatedGoods.GoodsName;
            colorCmb.SelectedIndex = updatedGoods.ID_Color.Value - 1;
            brandCmb.SelectedIndex = updatedGoods.ID_Brand.Value - 1;
            sizeCmb.SelectedIndex = updatedGoods.ID_Size.Value - 1;
            typeCmb.SelectedIndex = updatedGoods.ID_Type.Value - 1;
            numberTextBox.Text = $"{updatedGoods.Number}";
            importDateDatePicker.SelectedDate = updatedGoods.Import_Date;
            priceTextBox.Text = $"{updatedGoods.Price.Value}";
            addedPicture.Source = new BitmapImage(new Uri(updatedGoods.Picture, UriKind.RelativeOrAbsolute));
        }

        private void addPictureButton_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialogScreen = new OpenFileDialog();

            if (openFileDialogScreen.ShowDialog() == true)
            {
                addedPicture.Source = new BitmapImage(new Uri(openFileDialogScreen.FileName.ToString(), UriKind.RelativeOrAbsolute));
            }
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            var ValidationWindowScreen = new ValidationWindow("UPDATE");

            if (ValidationWindowScreen.ShowDialog() == true)
            {
                tempUpdatedGoods.GoodsCode = goodsCodeTextBox.Text;
                tempUpdatedGoods.GoodsName = goodsNameTextBox.Text;
                tempUpdatedGoods.ID_Color = colorCmb.SelectedIndex + 1;
                tempUpdatedGoods.ID_Brand = brandCmb.SelectedIndex + 1;
                tempUpdatedGoods.ID_Size = sizeCmb.SelectedIndex + 1;
                tempUpdatedGoods.ID_Type = typeCmb.SelectedIndex + 1;
                tempUpdatedGoods.Number = int.Parse(numberTextBox.Text);
                tempUpdatedGoods.Import_Date = importDateDatePicker.SelectedDate;
                tempUpdatedGoods.Price = double.Parse(priceTextBox.Text);
                tempUpdatedGoods.Picture = addedPicture.Source.ToString();

                busGoods.UpdateGoods(tempUpdatedGoods);

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
            var ValidationWindowScreen = new ValidationWindow("DELETE");

            if (ValidationWindowScreen.ShowDialog() == true)
            {
                busGoods.DeleteGoods(tempUpdatedGoods);

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
    }
}
