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
using System.Windows.Controls.DataVisualization.Charting;
using LIMUPA.BUS;

namespace LIMUPA.GUI
{
    /// <summary>
    /// Interaction logic for YearSummaryWindow.xaml
    /// </summary>
    public partial class YearSummaryWindow : Window
    {
        BUS_Bill busBill = new BUS_Bill();
        BUS_Expenses busExpenses = new BUS_Expenses();

        public YearSummaryWindow(int mode)
        {
            InitializeComponent();

            if (mode == 0)
            {
                captionChart.Title = "Yearly Revenue";
                monthsummaryChart.Title = $"BIỂU ĐỒ TĂNG TRƯỞNG DANH THU HÀNG NĂM (TỪ 2015 ĐẾN NAY)";
                LoadYearlyRevenueLineChartData();
            }
            else if (mode == 1)
            {
                captionChart.Title = "Yearly Profit";
                monthsummaryChart.Title = $"BIỂU ĐỒ TĂNG TRƯỞNG LỢI NHUẬN HÀNG NĂM (TỪ 2015 ĐẾN NAY)";
                LoadYearlyProfitLineChartData();
            }
        }

        public void LoadYearlyRevenueLineChartData()
        {
            KeyValuePair<int, double>[] yearlyrevenueData = new KeyValuePair<int, double>[DateTime.Now.Year - 2015 + 1];

            for (int i = 2015; i <= DateTime.Now.Year; i++)
            {
                double revenue = busBill.GetTotalBillsByYear(i);

                yearlyrevenueData[i - 2015] = new KeyValuePair<int, double>(i, revenue);
            }

            ((LineSeries)monthsummaryChart.Series[0]).ItemsSource = yearlyrevenueData;
        }

        public void LoadYearlyProfitLineChartData()
        {
            KeyValuePair<int, double>[] yearlyprofitData = new KeyValuePair<int, double>[DateTime.Now.Year - 2015 + 1];

            for (int i = 2015; i <= DateTime.Now.Year; i++)
            {
                double revenue = busBill.GetTotalBillsByYear(i);
                double expenses = busExpenses.GetTotalExpensesByYear(i);

                yearlyprofitData[i - 2015] = new KeyValuePair<int, double>(i, revenue - expenses);
            }

            ((LineSeries)monthsummaryChart.Series[0]).ItemsSource = yearlyprofitData;
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
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
