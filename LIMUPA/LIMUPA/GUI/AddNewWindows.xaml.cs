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
    /// Interaction logic for AddNewWindows.xaml
    /// </summary>
    public partial class AddNewWindows : Window
    {
        BUS_Goods busGoods = new BUS_Goods();
        BUS_Color busColor = new BUS_Color();
        BUS_Brand busBrand = new BUS_Brand();
        BUS_Type busType = new BUS_Type();
        BUS_Size busSize = new BUS_Size();

        public AddNewWindows()
        {
            InitializeComponent();

            colorCmb.ItemsSource = busColor.GetAllColors();
            brandCmb.ItemsSource = busBrand.GetAllBrands();
            typeCmb.ItemsSource = busType.GetAllTypes();
            sizeCmb.ItemsSource = busSize.GetAllSizes();
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

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(System.AppDomain.CurrentDomain.BaseDirectory);
            //MessageBox.Show(addedPicture.Source.ToString());

            Good newGoods = new Good()
            {
                GoodsCode = goodsCode.Text,
                GoodsName = goodsName.Text,
                Color = colorCmb.SelectedIndex + 1,
                Brand = brandCmb.SelectedIndex + 1,
                Size = sizeCmb.SelectedIndex + 1,
                Type = typeCmb.SelectedIndex + 1,
                Price = double.Parse(priceTextBox.Text),
                Picture = addedPicture.Source.ToString()
            };

            busGoods.AddGoods(newGoods);

            this.DialogResult = true;
            this.Close();       
        }
    }
}
