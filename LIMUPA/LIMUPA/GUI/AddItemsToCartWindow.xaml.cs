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

namespace LIMUPA.GUI
{
    /// <summary>
    /// Interaction logic for AddItemsToCartWindow.xaml
    /// </summary>
    public partial class AddItemsToCartWindow : Window
    {
        public int Number { get; set; }
        Good tempAddedItemsToCartGoods = new Good();


        public AddItemsToCartWindow(Good addedItemsToCartGoods)
        {
            InitializeComponent();

            tempAddedItemsToCartGoods = addedItemsToCartGoods;
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            var number = int.Parse(numberTextBox.Text);

            if(tempAddedItemsToCartGoods.Number < number)
            {
                validationAccessText.Text = "DON'T HAVE ENOUGH NUMBERS OF THIS GOODS. PLEASE TYPE AGAIN";

                return;
            }
            else
            {
                Number = number;
                this.DialogResult = true;
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false; ;
            this.Close();
        }
    }
}
