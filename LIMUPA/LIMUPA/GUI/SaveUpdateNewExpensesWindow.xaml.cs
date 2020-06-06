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
    /// Interaction logic for AddNewExpensesWindow.xaml
    /// </summary>
    public partial class SaveUpdateNewExpensesWindow : Window
    {
        BUS_Expenses busExpenses = new BUS_Expenses();
        Expens tempSaveUpdateExpenses = new Expens();

        public SaveUpdateNewExpensesWindow(int mode, Expens saveupdateExpenses)
        {
            InitializeComponent();

            if (mode == 1)
            {
                tempSaveUpdateExpenses = saveupdateExpenses;
                date.SelectedDate = saveupdateExpenses.DateTime;
                //totalTextBlock.Text = $"{saveupdateExpenses.Total.Value}";    //Total tự cập nhật
                electricTextBox.Text = $"{saveupdateExpenses.Electric.Value}";
                waterTextBox.Text = $"{saveupdateExpenses.Water.Value}";
                premisesTextBox.Text = $"{saveupdateExpenses.Rent_Premises.Value}";
                salaryTextBox.Text = $"{saveupdateExpenses.SalaryStaff.Value}";
                goodsTextBox.Text = $"{saveupdateExpenses.Goods.Value}";

                saveButton.Visibility = Visibility.Collapsed;
                updateButton.Visibility = Visibility.Visible;
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

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            var ValidationWindowScreen = new ValidationWindow("SAVE");

            if (ValidationWindowScreen.ShowDialog() == true)
            {
                Expens newExpenses = new Expens()
                {
                    Electric = float.Parse(electricTextBox.Text),
                    Water = float.Parse(waterTextBox.Text),
                    Rent_Premises = float.Parse(premisesTextBox.Text),
                    DateTime = date.SelectedDate,
                    SalaryStaff = float.Parse(salaryTextBox.Text),
                    Goods = float.Parse(goodsTextBox.Text),
                    Total = float.Parse(totalTextBlock.Text),
                };

                busExpenses.AddExpenses(newExpenses);

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

        string preElectric = "0";
        private void electricTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (electricTextBox.Text == "")
            {
                electricTextBox.Text = "0";
            }

            float total = float.Parse(totalTextBlock.Text);
            total -= float.Parse(preElectric);
            total += float.Parse(electricTextBox.Text);

            preElectric = electricTextBox.Text;
            totalTextBlock.Text = $"{total}";
        }

        string preWater = "0";
        private void waterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (waterTextBox.Text == "")
            {
                waterTextBox.Text = "0";
            }

            float total = float.Parse(totalTextBlock.Text);
            total -= float.Parse(preWater);
            total += float.Parse(waterTextBox.Text);

            preWater = waterTextBox.Text;
            totalTextBlock.Text = $"{total}";
        }

        string prePremises = "0";
        private void premisesTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (premisesTextBox.Text == "")
            {
                premisesTextBox.Text = "0";
            }

            float total = float.Parse(totalTextBlock.Text);
            total -= float.Parse(prePremises);
            total += float.Parse(premisesTextBox.Text);

            prePremises = premisesTextBox.Text;
            totalTextBlock.Text = $"{total}";
        }

        string preSalary = "0";
        private void salaryTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (salaryTextBox.Text == "")
            {
                salaryTextBox.Text = "0";
            }

            float total = float.Parse(totalTextBlock.Text);
            total -= float.Parse(preSalary);
            total += float.Parse(salaryTextBox.Text);

            preSalary = salaryTextBox.Text;
            totalTextBlock.Text = $"{total}";
        }

        string preGoods = "0";
        private void goodsTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (goodsTextBox.Text == "")
            {
                goodsTextBox.Text = "0";
            }

            float total = float.Parse(totalTextBlock.Text);
            total -= float.Parse(preGoods);
            total += float.Parse(goodsTextBox.Text);

            preGoods = goodsTextBox.Text;
            totalTextBlock.Text = $"{total}";
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            var ValidationWindowScreen = new ValidationWindow("UPDATE");

            if (ValidationWindowScreen.ShowDialog() == true)
            {
                tempSaveUpdateExpenses.Electric = float.Parse(electricTextBox.Text);
                tempSaveUpdateExpenses.Water = float.Parse(waterTextBox.Text);
                tempSaveUpdateExpenses.Rent_Premises = float.Parse(premisesTextBox.Text);
                tempSaveUpdateExpenses.DateTime = date.SelectedDate;
                tempSaveUpdateExpenses.SalaryStaff = float.Parse(salaryTextBox.Text);
                tempSaveUpdateExpenses.Goods = float.Parse(goodsTextBox.Text);
                tempSaveUpdateExpenses.Total = float.Parse(totalTextBlock.Text);

                busExpenses.UpdateExpenses(tempSaveUpdateExpenses);

                this.DialogResult = true;
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
