using BUS;
using DTO;
using System.Windows.Controls;
using System.Windows.Input;
namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for HoaDon.xaml
    /// </summary>
    public partial class HoaDon : UserControl
    {
        BUS_USER user_bus = new BUS_USER();
        public HoaDon()
        {
            InitializeComponent();
            Hoadonlistview.ItemsSource = user_bus.getallHDListforShow();
        }

        private void Hoadonlistview_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Hoadonlistview.SelectedItems.Count == 1)
            {
                TThoadon inst = new TThoadon();
                CTHoadonforShow selected = (CTHoadonforShow)Hoadonlistview.SelectedItems[0];
                inst.initdata(user_bus.gethd(selected.HoadonID));
                inst.Show();
            }
        }
    }
}
