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
    /// Interaction logic for GoodsInformation.xaml
    /// </summary>
    public partial class GoodsInformation : Window
    {
        public GoodsInformation(Good good)
        {
            InitializeComponent();

            this.DataContext = good;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }


    }
}
