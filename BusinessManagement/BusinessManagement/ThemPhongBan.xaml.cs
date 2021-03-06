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
using BUS;
using DTO;

namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for ThemPhongBan.xaml
    /// </summary>
    public partial class ThemPhongBan : Window
    {
        BUS_USER user_bus = new BUS_USER();
        public ThemPhongBan()
        {
            InitializeComponent();
        }

        private void tbSDTPB_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space) e.Handled = true;
        }

        private void tbSDTPB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
        }

        private void btnThemPB_Click(object sender, RoutedEventArgs e)
        {
            user_bus.add_new_PB(tbMaPB.Text, tbTenPB.Text, tbSDTPB.Text, tbemailPB.Text, "", "");
        }
    }
}
