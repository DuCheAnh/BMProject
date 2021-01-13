using BUS;
using System.Collections.Generic;
using System.Windows.Controls;
namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for HangHoa.xaml
    /// </summary>
    public partial class HangHoa : UserControl
    {
        BUS_USER user_bus = new BUS_USER();

        public HangHoa()
        {
            InitializeComponent();
            LVsetup();
        }
        void LVsetup()
        {
            HanghoaLV.ItemsSource = user_bus.get_listof_hanghoalv();
        }

    }
}
