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
    /// Interaction logic for MonthSummaryWindow.xaml
    /// </summary>
    public partial class MonthSummaryWindow : Window
    {
        BUS_Bill busBill = new BUS_Bill();
        BUS_Expenses busExpenses = new BUS_Expenses();

        public MonthSummaryWindow(int mode, int year)
        {
            InitializeComponent();

            if (mode == 0)
            {
                captionChart.Title = "Monthly Revenue";
                monthsummaryChart.Title = $"BIỂU ĐỒ TĂNG TRƯỞNG DANH THU HÀNG THÁNG NĂM {year}";
                LoadMontlyRevenueLineChartData(year);
            }
            else if (mode == 1)
            {
                captionChart.Title = "Monthly Profit";
                monthsummaryChart.Title = $"BIỂU ĐỒ TĂNG TRƯỞNG LỢI NHUẬN HÀNG THÁNG NĂM {year}";
                LoadMontlyProfitLineChartData(year);
            }

        }

        private void LoadMontlyRevenueLineChartData(int year)
        {
            KeyValuePair<int, double>[] monthlyrevenueData = new KeyValuePair<int, double>[12];

            for (int i = 1; i <= 12; i++)
            {
                double revenue = busBill.GetTotalBillsByMonth(i, year);

                monthlyrevenueData[i - 1] = new KeyValuePair<int, double>(i, revenue);
            }

            ((LineSeries)monthsummaryChart.Series[0]).ItemsSource = monthlyrevenueData;
        }

        public void LoadMontlyProfitLineChartData(int year)
        {
            KeyValuePair<int, double>[] monthlyprofitData = new KeyValuePair<int, double>[12];

            for (int i = 1; i <= 12; i++)
            {
                double revenue = busBill.GetTotalBillsByMonth(i, year);
                double expenses = busExpenses.GetTotalExpensesByMonth(i, year);

                monthlyprofitData[i - 1] = new KeyValuePair<int, double>(i, revenue - expenses);
            }

            ((LineSeries)monthsummaryChart.Series[0]).ItemsSource = monthlyprofitData;
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
