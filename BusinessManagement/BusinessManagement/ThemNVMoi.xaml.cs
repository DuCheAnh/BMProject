﻿using BUS;
using System.Collections.Generic;
using System.Windows;

namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for ThemNVMoi.xaml
    /// </summary>
    public partial class ThemNVMoi : Window
    {
        BUS_USER user_bus = new BUS_USER();
        public ThemNVMoi()
        {
            InitializeComponent();
        }

        private void btnThemNV_Click(object sender, RoutedEventArgs e)
        {
            if (user_bus.add_new_nv(HoTen.Text, MaNV.Text, Username.Text, Password.Password, DOB.SelectedDate.ToString(),
                Gender.Text, BirthPlace.Text, Address.Text, Position.Text, HopDong.Text, HDtill.SelectedDate.ToString(), 
                TrinhDo.Text, PBcombobox.Text,Email.Text,Luongthoathuan.Text))
                MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Thêm thất bại");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> listHD = user_bus.getallHD_ID();
            HopDong.ItemsSource = listHD;
            PBcombobox.ItemsSource = user_bus.getallPB_ID();
        }
    }
}
