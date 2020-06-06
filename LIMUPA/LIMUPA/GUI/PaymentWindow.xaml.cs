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


namespace LIMUPA.GUI
{
    /// <summary>
    /// Interaction logic for PaymentWindow.xaml
    /// </summary>
    public partial class PaymentWindow : Window
    {
        public PaymentWindow(int mode, string idBill, string customername, string phonenumber, string address,
                             string staffname, List<Good> goodsList, string total)
        {
            InitializeComponent();

            if (mode == 0)
            {
                paynowButton.Visibility = Visibility.Visible;
                okButton.Visibility = Visibility.Collapsed;
            }
            else if (mode == 1)
            {
                paynowButton.Visibility = Visibility.Collapsed;
                okButton.Visibility = Visibility.Visible;
            } 

            idTextBlock.Text = idBill;
            customernameTextBox.Text = customername;
            phonenumberTextBox.Text = phonenumber;
            addressTextBox.Text = address;
            staffnameTextBlock.Text = staffname;
            goodsListView.ItemsSource = goodsList;
            totalTextBlock.Text = total;
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void paynowButton_Click(object sender, RoutedEventArgs e)
        {
            var ValidationWindowScreen = new ValidationWindow("PAY NOW THIS BILL");

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

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
    }
}
