using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using LIMUPA.GUI;

namespace LIMUPA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BUS_Color busColor = new BUS_Color();
        BUS_Brand busBrand = new BUS_Brand();
        BUS_Type busType = new BUS_Type();
        BUS_Goods busGoods = new BUS_Goods();

        public MainWindow()
        {
            InitializeComponent();

            cmbColors1.ItemsSource = cmbColors2.ItemsSource = busColor.GetAllColors();
            cmbBrands1.ItemsSource = cmbBrands2.ItemsSource = busBrand.GetAllBrands();
            cmbTypes1.ItemsSource = cmbTypes2.ItemsSource = busType.GetAllTypes();
            goodsListView1.ItemsSource = busGoods.GetAllGoods();
            goodsListView2.ItemsSource = busGoods.GetAllGoods();


            //Thêm Filter vào Search
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(goodsListView2.ItemsSource);
            view.Filter = GoodsFilter;
        }


        private bool GoodsFilter(object item)
        {
            if (String.IsNullOrEmpty(searchTextBox2.Text) || searchTextBox2.Text.ToString().Contains("Mã Code"))
            {
                return true;
            }
            else
            {
                return ((item as Good).GoodsName.IndexOf(searchTextBox2.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                    || ((item as Good).GoodsCode.IndexOf(searchTextBox2.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            }
        }

        private void searchButton1_Click(object sender, RoutedEventArgs e)
        {
            if (searchTextBox1.Text.Contains("Mã Code") || searchTextBox1.Text.Length == 0)
            {
                return;
            }

            Good goods = busGoods.GetGoodsByGoodsCode(searchTextBox1.Text);

            if (goods.GoodsCode == searchTextBox1.Text)
            {
                var goodsInformationScreen = new GoodsInformation(goods);

                if (goodsInformationScreen.ShowDialog() == true)
                {
                    return;
                }
                else
                {
                    return;
                }
            }

            MessageBox.Show("Không tìm thấy...Vui lòng nhập lại Code!");
        }

        private void goodsListView1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedGoods = goodsListView1.SelectedIndex;
            List<Good> goods = busGoods.GetAllGoods();

            var goodsInformationScreen = new GoodsInformation(goods[selectedGoods]);

            if (goodsInformationScreen.ShowDialog() == true)
            {
                return;
            }
        }

        private void goodsListView2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedGoods = goodsListView2.SelectedItem as Good;

            Good updatedGoods = busGoods.GetGoodsById(selectedGoods.ID);

            if (updatedGoods.ID == selectedGoods.ID)
            {
                var updateWindowsScreen = new UpdateWindows(updatedGoods);

                if (updateWindowsScreen.ShowDialog() == true)
                {
                    goodsListView1.ItemsSource = busGoods.GetAllGoods();
                    goodsListView2.ItemsSource = busGoods.GetAllGoods();

                    //Thêm Filter vào Search
                    CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(goodsListView2.ItemsSource);
                    view.Filter = GoodsFilter;

                    return;
                }
                else
                {
                    return;
                }
            }
        }

        private void addNew_Click(object sender, RoutedEventArgs e)
        {
            var addNewindowsScreen = new AddNewWindows();
            
            if(addNewindowsScreen.ShowDialog() == true)
            {
                goodsListView1.ItemsSource = busGoods.GetAllGoods();
                goodsListView2.ItemsSource = busGoods.GetAllGoods();
            }

            //Thêm Filter vào Search
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(goodsListView2.ItemsSource);
            view.Filter = GoodsFilter;
        }

        private void searchTextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (searchTextBox2.Text.ToString().Contains("Mã Code"))
            {
                return;
            }
            CollectionViewSource.GetDefaultView(goodsListView2.ItemsSource).Refresh();
        }

        private void searchButton2_Click(object sender, RoutedEventArgs e)
        {
            if (searchTextBox2.Text.Contains("Mã Code") || searchTextBox2.Text.Length == 0)
            {
                return;
            }

            Good goods = busGoods.GetGoodsByGoodsCode(searchTextBox2.Text);

            if (goods.GoodsCode == searchTextBox2.Text)
            {
                var updateWindowsScreen = new UpdateWindows(goods);

                if (updateWindowsScreen.ShowDialog() == true)
                {
                    goodsListView1.ItemsSource = busGoods.GetAllGoods();
                    goodsListView2.ItemsSource = busGoods.GetAllGoods();

                    //Thêm Filter vào Search
                    CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(goodsListView2.ItemsSource);
                    view.Filter = GoodsFilter;

                    return;
                }
                else
                {
                    return;
                }
            }

            MessageBox.Show("Không tìm thấy...Vui lòng nhập lại Code!");
        }



        private void searchTextBox1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            searchTextBox1.Text = "";
        }

        private void searchTextBox2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            searchTextBox2.Text = "";
        }

        private void minimumPrice2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            minimumPrice2.Text = "";
        }

        private void maximumPrice2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            maximumPrice2.Text = "";
        }

        private void refreshButton2_Click(object sender, RoutedEventArgs e)
        {
            goodsListView2.ItemsSource = busGoods.GetAllGoods();


            cmbColors2.SelectedIndex = -1;
            cmbBrands2.SelectedIndex = -1;
            minimumPrice2.Text = "tối thiểu";
            maximumPrice2.Text = "tối đa";
            cmbTypes2.SelectedIndex = -1;

            //Thêm Filter vào Search
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(goodsListView2.ItemsSource);
            view.Filter = GoodsFilter;
        }

        private void filterButton2_Click(object sender, RoutedEventArgs e)
        {
            var filteredColor2 = cmbColors2.SelectedIndex + 1;
            var filteredBrand2 = cmbBrands2.SelectedIndex + 1;
            double filteredMinimumPrice2 = 0.0f;
            if (!minimumPrice2.Text.ToString().Contains("tối thiểu") && minimumPrice2.Text != "")
            {
                filteredMinimumPrice2 = double.Parse(minimumPrice2.Text);
            }
            double filteredMaximumPrice2 = 0.0f;
            if (!maximumPrice2.Text.ToString().Contains("tối đa") && minimumPrice2.Text != "")
            {
                filteredMaximumPrice2 = double.Parse(maximumPrice2.Text);
            }
            var filteredType2 = cmbTypes2.SelectedIndex + 1;

            goodsListView2.ItemsSource = busGoods.GetGoodsByFilter(filteredColor2, filteredBrand2, filteredMinimumPrice2, filteredMaximumPrice2, filteredType2);

            //Thêm Filter vào Search
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(goodsListView2.ItemsSource);
            view.Filter = GoodsFilter;
        }

        private void filterButton1_Click(object sender, RoutedEventArgs e)
        {
            var filteredColor1 = cmbColors1.SelectedIndex + 1;
            var filteredBrand1 = cmbBrands1.SelectedIndex + 1;
            double filteredMinimumPrice1 = 0.0f;
            if (!minimumPrice1.Text.ToString().Contains("tối thiểu") && minimumPrice1.Text != "")
            {
                filteredMinimumPrice1 = double.Parse(minimumPrice1.Text);
            }
            double filteredMaximumPrice1 = 0.0f;
            if (!maximumPrice1.Text.ToString().Contains("tối đa") && minimumPrice1.Text != "")
            {
                filteredMaximumPrice1 = double.Parse(maximumPrice1.Text);
            }
            var filteredType1 = cmbTypes1.SelectedIndex + 1;

            goodsListView1.ItemsSource = busGoods.GetGoodsByFilter(filteredColor1, filteredBrand1, filteredMinimumPrice1, filteredMaximumPrice1, filteredType1);

            //Thêm Filter vào Search
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(goodsListView1.ItemsSource);
            view.Filter = GoodsFilter;
        }

        private void refreshButton1_Click(object sender, RoutedEventArgs e)
        {
            goodsListView1.ItemsSource = busGoods.GetAllGoods();


            cmbColors1.SelectedIndex = -1;
            cmbBrands1.SelectedIndex = -1;
            minimumPrice1.Text = "tối thiểu";
            maximumPrice1.Text = "tối đa";
            cmbTypes1.SelectedIndex = -1;

            //Thêm Filter vào Search
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(goodsListView1.ItemsSource);
            view.Filter = GoodsFilter;
        }
    }
}
