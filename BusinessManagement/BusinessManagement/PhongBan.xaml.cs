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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DTO;
using BUS;
namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for PhongBan.xaml
    /// </summary>
    public partial class PhongBan : UserControl
    {
        public PhongBan()
        {
            InitializeComponent();
        }
        public void initPhongbanpage(PBData data)
        {
            PBnameTB.Text = data.tenpb;
        }
        private void btnThongKe_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void btnView_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
