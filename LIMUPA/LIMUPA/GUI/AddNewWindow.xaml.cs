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
    /// Interaction logic for AddNewWindow.xaml
    /// </summary>
    public partial class AddNewWindow : Window
    {
        BUS_Goods busGoods = new BUS_Goods();
        BUS_Color busColor = new BUS_Color();
        BUS_Brand busBrand = new BUS_Brand();
        BUS_Type busType = new BUS_Type();
        BUS_Size busSize = new BUS_Size();

        public AddNewWindow()
        {
            InitializeComponent();

            colorCmb.ItemsSource = busColor.GetAllColors();
            brandCmb.ItemsSource = busBrand.GetAllBrands();
            typeCmb.ItemsSource = busType.GetAllTypes();
            sizeCmb.ItemsSource = busSize.GetAllSizes();
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

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            if (goodsCodeTextBox.Text == "" || goodsNameTextBox.Text == "" || colorCmb.SelectedIndex == -1 || brandCmb.SelectedIndex == -1 || sizeCmb.SelectedIndex == -1 ||
                typeCmb.SelectedIndex == -1 || numberTextBox.Text == "" || importDateDatePicker.Text == "" || priceTextBox.Text == "")
            {
                var AnnouncementWindowScreen = new AnnouncementWindow("THE INFORMATION IS INVALID. PLEASE CHECK AGAIN...");

                if (AnnouncementWindowScreen.ShowDialog() == true)
                {
                    return;
                }
                else
                {
                    return;
                }
            }

            if (busGoods.IsGoodsCodeValid(goodsCodeTextBox.Text) == false)
            {
                var AnnouncementWindowScreen = new AnnouncementWindow("GOODSCODE IS INVALID");

                if (AnnouncementWindowScreen.ShowDialog() == true)
                {
                    return;
                }
                else
                {
                    return;
                }
            }

            Good newGoods = new Good()
            {
                GoodsCode = goodsCodeTextBox.Text,
                GoodsName = goodsNameTextBox.Text,
                ID_Color = colorCmb.SelectedIndex + 1,
                ID_Brand = brandCmb.SelectedIndex + 1,
                ID_Size = sizeCmb.SelectedIndex + 1,
                ID_Type = typeCmb.SelectedIndex + 1,
                Number = int.Parse(numberTextBox.Text),
                Import_Date = importDateDatePicker.SelectedDate,
                Price = double.Parse(priceTextBox.Text),
                Picture = addedPicture.Source.ToString(),
                ID_Sale = 1
            };

            var ValidationWindowScreen = new ValidationWindow("ADD NEW");

            if (ValidationWindowScreen.ShowDialog() == true)
            {
                busGoods.AddGoods(newGoods);

                this.DialogResult = true;
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void addPictureButton_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialogScreen = new OpenFileDialog();

            if (openFileDialogScreen.ShowDialog() == true)
            {
                addedPicture.Source = new BitmapImage(new Uri(openFileDialogScreen.FileName.ToString(), UriKind.RelativeOrAbsolute));
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
