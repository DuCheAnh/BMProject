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
using DTO;
using BUS;
namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for CapnhatLamthem.xaml
    /// </summary>
    public partial class CapnhatLamthem : Window
    {
        CTLamthem inst = new CTLamthem();
        BUS_USER user_bus = new BUS_USER();
        public CapnhatLamthem()
        {
            InitializeComponent();
        }
        public void init_data(CTLamthem data)
        {
            inst = data;
            hoanthanhtb.Text = data.sogiolamthem.ToString();
            Nhanvienlb.Content += data.tennv;
            Thanglb.Content += data.thang.ToString();
        }

        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {
            inst.sogiolamthem += int.Parse(themtb.Text);
            if (user_bus.update_ctlt(inst))
                MessageBox.Show("okay");
            
        }
    }
}
