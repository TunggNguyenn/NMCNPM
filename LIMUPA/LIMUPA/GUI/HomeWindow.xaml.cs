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
using LIMUPA.Converter;

namespace LIMUPA.GUI
{
    /// <summary>
    /// Interaction logic for HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        BUS_Color busColor = new BUS_Color();
        BUS_Brand busBrand = new BUS_Brand();
        BUS_Type busType = new BUS_Type();
        BUS_Goods busGoods = new BUS_Goods();
        BUS_Size busSize = new BUS_Size();
        BUS_Bill busBill = new BUS_Bill();
        BUS_Sale busSale = new BUS_Sale();
        BUS_Expenses busExpenses = new BUS_Expenses();
        

        UserConverter userConverter = new UserConverter();
        BindingList<Good> _goodsList = new BindingList<Good>();
        private int _userID = -1;

        public HomeWindow(int userID, string permisionName)
        {
            InitializeComponent();

            if (permisionName != "Quản lý")
            {
                settingButton.Visibility = Visibility.Collapsed;
                saleTabItem.Visibility = Visibility.Collapsed;
                expensesTabItem.Visibility = Visibility.Collapsed;
            }

            //Sale
            _userID = userID;
            id2TextBlock.Text = busBill.GetNextBillCode();
            staffnameTextBlock.Text = (string)userConverter.Convert(userID, null, null, null);
            goodsListView.ItemsSource = _goodsList;

            cmbColors1.ItemsSource = cmbColors2.ItemsSource = busColor.GetAllColors();
            cmbBrands1.ItemsSource = cmbBrands2.ItemsSource = busBrand.GetAllBrands();
            cmbTypes1.ItemsSource = cmbTypes2.ItemsSource = busType.GetAllTypes();
            cmbSizes1.ItemsSource = cmbSizes2.ItemsSource = busSize.GetAllSizes();

            goodsListView1.ItemsSource = busGoods.GetAllGoods();
            goodsListView2.ItemsSource = busGoods.GetAllGoods();

            //Add Filter into Search
            CollectionView filterView = (CollectionView)CollectionViewSource.GetDefaultView(goodsListView2.ItemsSource);
            filterView.Filter = GoodsFilter;


            //Sale
            goodsListView3.ItemsSource = busGoods.GetAllGoods();
            CollectionView saleView = (CollectionView)CollectionViewSource.GetDefaultView(goodsListView3.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("ID_Sale");
            saleView.GroupDescriptions.Add(groupDescription);


            //Expenses
            goodsListView4.ItemsSource = busExpenses.GetAllExpenses();
        }

        private bool GoodsFilter(object item)
        {
            if (String.IsNullOrEmpty(searchTextBox2.Text))
            {
                return true;
            }
            else
            {
                return ((item as Good).GoodsName.IndexOf(searchTextBox2.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                    || ((item as Good).GoodsCode.IndexOf(searchTextBox2.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            }
        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            var ValidationWindowScreen = new ValidationWindow("LOGOUT");

            if (ValidationWindowScreen.ShowDialog() == true)
            {
                this.DialogResult = true;
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
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void searchButton1_Click(object sender, RoutedEventArgs e)
        {
            if (searchTextBox1.Text.Length == 0)
            {
                return;
            }

            Good goods = busGoods.GetGoodsByGoodsCode(searchTextBox1.Text);

            if (goods.GoodsCode == searchTextBox1.Text)
            {
                var GoodsInformationWindowScreen = new GoodsInformationWindow(goods);

                if (GoodsInformationWindowScreen.ShowDialog() == true)
                {
                    return;
                }
                else
                {
                    return;
                }
            }

            //MessageBox.Show("Không tìm thấy...Vui lòng nhập lại Code!");
            var AnnouncementWindowScreen = new AnnouncementWindow("DON'T FIND THIS CODE...PLEASE TYPE AGAIN!");

            if (AnnouncementWindowScreen.ShowDialog() == true)
            {
                return;
            }
            else
            {
                return;
            }
        }

        private void minimumPrice1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            minimumPrice1.Text = "";
        }

        private void maximumPrice1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            maximumPrice1.Text = "";
        }

        private void goodsListView1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedGoods = goodsListView1.SelectedIndex;
            //List<Good> goods = busGoods.GetAllGoods();
            List<Good> goods = goodsListView1.ItemsSource as List<Good>;

            var GoodsInformationWindowScreen = new GoodsInformationWindow(goods[selectedGoods]);

            if (GoodsInformationWindowScreen.ShowDialog() == true)
            {
                return;
            }
            else
            {
                return;
            }
        }

        private void refreshButton1_Click(object sender, RoutedEventArgs e)
        {
            var ValidationWindowScreen = new ValidationWindow("REFRESH");

            if (ValidationWindowScreen.ShowDialog() == true)
            {
                goodsListView1.ItemsSource = busGoods.GetAllGoods();

                searchTextBox1.Text = "";
                cmbColors1.SelectedIndex = -1;
                cmbBrands1.SelectedIndex = -1;
                minimumPrice1.Text = "minimum";
                maximumPrice1.Text = "maximum";
                cmbTypes1.SelectedIndex = -1;
                cmbSizes1.SelectedIndex = -1;
            }
            else
            {
                return;
            }
        }

        private void filterButton1_Click(object sender, RoutedEventArgs e)
        {
            var filteredColor1 = cmbColors1.SelectedIndex + 1;
            var filteredBrand1 = cmbBrands1.SelectedIndex + 1;
            double filteredMinimumPrice1 = 0.0f;
            if (!minimumPrice1.Text.ToString().Contains("minimum") && minimumPrice1.Text != "")
            {
                filteredMinimumPrice1 = double.Parse(minimumPrice1.Text);
            }
            double filteredMaximumPrice1 = 0.0f;
            if (!maximumPrice1.Text.ToString().Contains("maximum") && maximumPrice1.Text != "")
            {
                filteredMaximumPrice1 = double.Parse(maximumPrice1.Text);
            }
            var filteredType1 = cmbTypes1.SelectedIndex + 1;
            var filteredSize1 = cmbSizes1.SelectedIndex + 1;

            goodsListView1.ItemsSource = busGoods.GetGoodsByFilter(filteredColor1, filteredBrand1, filteredMinimumPrice1, filteredMaximumPrice1, filteredType1, filteredSize1);
        }

        private void searchTextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (searchTextBox2.Text.ToString() == "")
            {
                return;
            }
            CollectionViewSource.GetDefaultView(goodsListView2.ItemsSource).Refresh();
        }

        private void searchButton2_Click(object sender, RoutedEventArgs e)
        {
            if (searchTextBox2.Text.Length == 0)
            {
                return;
            }

            Good goods = busGoods.GetGoodsByGoodsCode(searchTextBox2.Text);

            if (goods.GoodsCode == searchTextBox2.Text)
            {
                var GoodsInformationWindowScreen = new GoodsInformationWindow(goods);

                if (GoodsInformationWindowScreen.ShowDialog() == true)
                {
                    return;
                }
                else
                {
                    return;
                }
            }

            //MessageBox.Show("Không tìm thấy...Vui lòng nhập lại Code!");
            var AnnouncementWindowScreen = new AnnouncementWindow("DON'T FIND THIS CODE...PLEASE TYPE AGAIN!");

            if (AnnouncementWindowScreen.ShowDialog() == true)
            {
                return;
            }
            else
            {
                return;
            }
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
            var ValidationWindowScreen = new ValidationWindow("REFRESH");

            if (ValidationWindowScreen.ShowDialog() == true)
            {
                goodsListView2.ItemsSource = busGoods.GetAllGoods();

                searchTextBox1.Text = "";
                cmbColors2.SelectedIndex = -1;
                cmbBrands2.SelectedIndex = -1;
                minimumPrice2.Text = "minimum";
                maximumPrice2.Text = "maximum";
                cmbTypes2.SelectedIndex = -1;
                cmbSizes2.SelectedIndex = -1;
            }
            else
            {
                return;
            }
        }

        private void filterButton2_Click(object sender, RoutedEventArgs e)
        {
            var filteredColor2 = cmbColors2.SelectedIndex + 1;
            var filteredBrand2 = cmbBrands2.SelectedIndex + 1;
            double filteredMinimumPrice2 = 0.0f;
            if (!minimumPrice2.Text.ToString().Contains("minimum") && minimumPrice2.Text != "")
            {
                filteredMinimumPrice2 = double.Parse(minimumPrice2.Text);
            }
            double filteredMaximumPrice2 = 0.0f;
            if (!maximumPrice2.Text.ToString().Contains("maximum") && maximumPrice2.Text != "")
            {
                filteredMaximumPrice2 = double.Parse(maximumPrice2.Text);
            }
            var filteredType2 = cmbTypes2.SelectedIndex + 1;
            var filteredSize2 = cmbSizes2.SelectedIndex + 1;

            goodsListView2.ItemsSource = busGoods.GetGoodsByFilter(filteredColor2, filteredBrand2, filteredMinimumPrice2, filteredMaximumPrice2, filteredType2, filteredSize2);
        }

        private void goodsListView2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedGoods = goodsListView2.SelectedItem as Good;

            Good updatedGoods = busGoods.GetGoodsById(selectedGoods.ID);

            if (updatedGoods.ID == selectedGoods.ID)
            {
                var UpdateWindowScreen = new UpdateWindow(updatedGoods);

                if (UpdateWindowScreen.ShowDialog() == true)
                {
                    goodsListView1.ItemsSource = busGoods.GetAllGoods();
                    goodsListView2.ItemsSource = busGoods.GetAllGoods();

                    //Grouping goodsListView3
                    goodsListView3.ItemsSource = busGoods.GetAllGoods();
                    CollectionView saleView = (CollectionView)CollectionViewSource.GetDefaultView(goodsListView3.ItemsSource);
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

        private void addNewButton_Click(object sender, RoutedEventArgs e)
        {
            var AddNewindowScreen = new AddNewWindow();

            if (AddNewindowScreen.ShowDialog() == true)
            {
                goodsListView1.ItemsSource = busGoods.GetAllGoods();
                goodsListView2.ItemsSource = busGoods.GetAllGoods();

                //Grouping goodsListView3
                goodsListView3.ItemsSource = busGoods.GetAllGoods();
                CollectionView saleView = (CollectionView)CollectionViewSource.GetDefaultView(goodsListView3.ItemsSource);
                PropertyGroupDescription groupDescription = new PropertyGroupDescription("ID_Sale");
                saleView.GroupDescriptions.Add(groupDescription);

                return;
            }
            else
            {
                return;
            }
        }

        private void searchButton3_Click(object sender, RoutedEventArgs e)
        {
            if (searchTextBox3.Text.Length == 0)
            {
                return;
            }

            Good goods = busGoods.GetGoodsByGoodsCode(searchTextBox3.Text);

            if (goods.GoodsCode == searchTextBox3.Text)
            {
                var SaleGoodsInfoWindowScreen = new SaleGoodsInfoWindow(goods);

                if (SaleGoodsInfoWindowScreen.ShowDialog() == true)
                {
                    return;
                }
                else
                {
                    return;
                }
            }

            //MessageBox.Show("Không tìm thấy...Vui lòng nhập lại Code!");
            var AnnouncementWindowScreen = new AnnouncementWindow("DON'T FIND THIS CODE...PLEASE TYPE AGAIN!");

            if (AnnouncementWindowScreen.ShowDialog() == true)
            {
                return;
            }
            else
            {
                return;
            }
        }

        private void goodsListView3_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //
            if (goodsListView3.SelectedIndex == -1)
            {
                return;
            }

            var selectedGoods = goodsListView3.SelectedItem as Good;

            Good updatedGoods = busGoods.GetGoodsById(selectedGoods.ID);

            if (updatedGoods.ID == selectedGoods.ID)
            {
                var UpdateSaleGoodsWindowScreen = new UpdateSaleGoodsWindow(updatedGoods);

                if (UpdateSaleGoodsWindowScreen.ShowDialog() == true)
                {
                    goodsListView1.ItemsSource = busGoods.GetAllGoods();
                    goodsListView2.ItemsSource = busGoods.GetAllGoods();

                    //
                    goodsListView3.ItemsSource = busGoods.GetAllGoods();
                    CollectionView saleView = (CollectionView)CollectionViewSource.GetDefaultView(goodsListView3.ItemsSource);
                    PropertyGroupDescription groupDescription = new PropertyGroupDescription("ID_Sale");
                    saleView.GroupDescriptions.Add(groupDescription);

                    //return;
                }
                else
                {
                    return;
                }
            }
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            if (searchTextBox.Text.Length == 0)
            {
                return;
            }

            Good goods = busGoods.GetGoodsByGoodsCode(searchTextBox.Text);

            if (goods.GoodsCode == searchTextBox.Text)
            {
                var AddItemsToCartWindowScreen = new AddItemsToCartWindow(goods);

                if (AddItemsToCartWindowScreen.ShowDialog() == true)
                {
                    for(int i = 1; i <= AddItemsToCartWindowScreen.Number; i++)
                    {
                        _goodsList.Add(goods);
                        PlusCurrentTotal((float)goods.Price, (int)goods.ID_Sale);
                    }

                    return;
                }
                else
                {
                    return;
                }
            }

            //MessageBox.Show("Không tìm thấy...Vui lòng nhập lại Code!");
            var AnnouncementWindowScreen = new AnnouncementWindow("DON'T FIND THIS CODE...PLEASE TYPE AGAIN!");

            if (AnnouncementWindowScreen.ShowDialog() == true)
            {
                return;
            }
            else
            {
                return;
            }
        }

        public void PlusCurrentTotal(float price, int id_Sale)
        {
            int percentageSale = busSale.GetPercentageByIDSale(id_Sale);

            float currentTotal = float.Parse(totalTextBlock.Text);
            currentTotal += price;
            currentTotal -= (float)(price * (float)percentageSale / 100);

            totalTextBlock.Text = $"{currentTotal}";
        }

        public void SubstractCurrentTotal(float price, int id_Sale)
        {
            int percentageSale = busSale.GetPercentageByIDSale(id_Sale);

            float currentTotal = float.Parse(totalTextBlock.Text);
            currentTotal -= price;
            currentTotal += (float)(price * (float)percentageSale / 100);

            totalTextBlock.Text = $"{currentTotal}";
        }


        private void removeMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var removedGoodsIndex = goodsListView.SelectedIndex;

            if (removedGoodsIndex == -1)
            {
                return;
            }

            var ValidationWindowScreen = new ValidationWindow("REMOVE THIS ITEM");

            if (ValidationWindowScreen.ShowDialog() == true)
            {
                SubstractCurrentTotal((float)_goodsList[removedGoodsIndex].Price, (int)_goodsList[removedGoodsIndex].ID_Sale);
                _goodsList.RemoveAt(removedGoodsIndex);
            }
            else
            {
                return;
            }
        }

        private void cancelbillButton_Click(object sender, RoutedEventArgs e)
        {
            var ValidationWindowScreen = new ValidationWindow("CANCEL THIS BILL");

            if (ValidationWindowScreen.ShowDialog() == true)
            {
                customernameTextBox.Text = "";
                phonenumberTextBox.Text = "";
                addressTextBox.Text = "";
                totalTextBlock.Text = "0";
                cashTextBox.Text = "0";
                _goodsList.Clear();

                return;
            }
            else
            {
                return;
            }
        }

        private void doneButton_Click(object sender, RoutedEventArgs e)
        {
            var PaymentWindowScreen = new PaymentWindow(0, id2TextBlock.Text, customernameTextBox.Text, phonenumberTextBox.Text, addressTextBox.Text,
                                                        staffnameTextBlock.Text, _goodsList.ToList(), totalTextBlock.Text);

            if (PaymentWindowScreen.ShowDialog() == true)
            {
                for (int i = 0; i < _goodsList.Count; i++)
                {
                    Bill newBill = new Bill()
                    {
                        BillCode = id2TextBlock.Text,
                        CustomerName = customernameTextBox.Text,
                        CustomerPhoneNumber = phonenumberTextBox.Text,
                        CustomerAddress = addressTextBox.Text,
                        ID_Staff = _userID,
                        ID_Goods = _goodsList[i].ID,
                        DateTime = DateTime.Now.Date,
                        Total = double.Parse(totalTextBlock.Text),
                        VAT = 10,
                    };

                    //Decrease number of this goods
                    _goodsList[i].Number--;
                    busGoods.UpdateGoods(_goodsList[i]);


                    busBill.AddBill(newBill);
                }

                //Giống sự kiện cancelbillButton_Click
                id2TextBlock.Text = busBill.GetNextBillCode();
                customernameTextBox.Text = "";
                phonenumberTextBox.Text = "";
                addressTextBox.Text = "";
                totalTextBlock.Text = "0";
                cashTextBox.Text = "0";
                _goodsList.Clear();

                return;
            }
            else
            {
                return;
            }

        }

        private void addNewSaleButton_Click(object sender, RoutedEventArgs e)
        {
            var AddNewSaleWindowScreen = new AddNewSaleWindow(goodsListView1, goodsListView2, goodsListView3);

            if (AddNewSaleWindowScreen.ShowDialog() == true)
            {
                goodsListView1.ItemsSource = busGoods.GetAllGoods();
                goodsListView2.ItemsSource = busGoods.GetAllGoods();

                //Grouping goodsListView3
                goodsListView3.ItemsSource = busGoods.GetAllGoods();
                CollectionView saleView = (CollectionView)CollectionViewSource.GetDefaultView(goodsListView3.ItemsSource);
                PropertyGroupDescription groupDescription = new PropertyGroupDescription("ID_Sale");
                saleView.GroupDescriptions.Add(groupDescription);

                return;
            }
            else
            {
                return;
            }
        }

        private void addNewExpensesButton_Click(object sender, RoutedEventArgs e)
        {
            var SaveUpdateNewExpensesWindowScreen = new SaveUpdateNewExpensesWindow(0, null);

            if (SaveUpdateNewExpensesWindowScreen.ShowDialog() == true)
            {
                goodsListView4.ItemsSource = busExpenses.GetAllExpenses();

                return;
            }
            else
            {
                return;
            }
        }

        private void deleteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var deletedGoodsIndex = goodsListView4.SelectedIndex;

            if (deletedGoodsIndex == -1)
            {
                return;
            }

            var ValidationWindowScreen = new ValidationWindow("DELETE THIS ITEM");

            if (ValidationWindowScreen.ShowDialog() == true)
            {
                busExpenses.DeleteExpenses((Expens)goodsListView4.SelectedItem);

                goodsListView4.ItemsSource = busExpenses.GetAllExpenses();

                return;
            }
            else
            {
                return;
            }
        }

        private void editMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var deletedGoodsIndex = goodsListView4.SelectedIndex;

            if (deletedGoodsIndex == -1)
            {
                return;
            }

            var SaveUpdateNewExpensesWindowScreen = new SaveUpdateNewExpensesWindow(1, (Expens)goodsListView4.SelectedItem);

            if (SaveUpdateNewExpensesWindowScreen.ShowDialog() == true)
            {
                goodsListView4.ItemsSource = busExpenses.GetAllExpenses();

                return;
            }
            else
            {
                return;
            }
        }


        private void daylyrevenueBtn_Click(object sender, RoutedEventArgs e)
        {
            if (dayrevenueDatePicker.Text == "")
            {
                return;
            }

            var DayRevenueWindowScreen = new DayRevenueWindow((DateTime)dayrevenueDatePicker.SelectedDate);

            if (DayRevenueWindowScreen.ShowDialog() == true)
            {
                return;
            }

            else
            {
                return;
            }
        }


        private void monthlyrevenueBtn_Click(object sender, RoutedEventArgs e)
        {
            if (monthrevenueTextBox.Text == "")
            {
                return;
            }

            var MonthSummaryWindowScreen = new MonthSummaryWindow(0, int.Parse(monthrevenueTextBox.Text));

            if (MonthSummaryWindowScreen.ShowDialog() == true)
            {
                return;
            }

            else
            {
                return;
            }
        }


        private void monthlyprofitBtn_Click(object sender, RoutedEventArgs e)
        {
            if (monthprofitTextBox.Text == "")
            {
                return;
            }

            var MonthSummaryWindowScreen = new MonthSummaryWindow(1, int.Parse(monthprofitTextBox.Text));

            if (MonthSummaryWindowScreen.ShowDialog() == true)
            {
                return;
            }

            else
            {
                return;
            }
        }

        private void yearlyrevenueBtn_Click(object sender, RoutedEventArgs e)
        {
            var YearSummaryWindowScreen = new YearSummaryWindow(0);

            if (YearSummaryWindowScreen.ShowDialog() == true)
            {
                return;
            }

            else
            {
                return;
            }
        }

        private void yearlyprofitBtn_Click(object sender, RoutedEventArgs e)
        {
            var YearSummaryWindowScreen = new YearSummaryWindow(1);

            if (YearSummaryWindowScreen.ShowDialog() == true)
            {
                return;
            }

            else
            {
                return;
            }
        }

        private void settingButton_Click(object sender, RoutedEventArgs e)
        {
            var SettingWindowScreen = new SettingWindow();

            if (SettingWindowScreen.ShowDialog() == true)
            {
                return;
            }
            else
            {
                return;
            }
        }

        private void cashTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(cashTextBox.Text == "")
            {
                cashTextBox.Text = "0";
            }
        }

        private void viewbillButton_Click(object sender, RoutedEventArgs e)
        {
            var ViewBillWindowScreen = new ViewBillWindow();

            if (ViewBillWindowScreen.ShowDialog() == true)
            {

            }
            else
            {
                return;
            }
        }
    }
}
