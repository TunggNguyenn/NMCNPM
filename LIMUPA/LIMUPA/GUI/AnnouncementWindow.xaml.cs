﻿using System;
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
    /// Interaction logic for AnnouncementWindow.xaml
    /// </summary>
    public partial class AnnouncementWindow : Window
    {
        public AnnouncementWindow(string s)
        {
            InitializeComponent();

            validationAccessText.Text = $"{s}";
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
    }
}