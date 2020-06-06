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
    /// Interaction logic for DayRevenueWindow.xaml
    /// </summary>
    public partial class DayRevenueWindow : Window
    {
        BUS_Bill busBill = new BUS_Bill();

        public DayRevenueWindow(DateTime dayRevenue)
        {
            InitializeComponent();

            dayrevenueTextBlock.Text = $"{busBill.GetTotalByDateTime(dayRevenue)}";
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
