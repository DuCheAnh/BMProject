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
    /// Interaction logic for DSPhongBan.xaml
    /// </summary>
    public partial class DSPhongBan : UserControl
    {
        BUS_USER user_bus = new BUS_USER();
        public DSPhongBan()
        {
            InitializeComponent();
            PBList.ItemsSource = user_bus.getallPB();
        }

        private void Phongban_rep_Click(object sender, RoutedEventArgs e)
        {
            List<Label> labelist = new List<Label>();
            Button btn = (Button)sender;
            Canvas canv = (Canvas)btn.Content;
            foreach(Label lab in canv.Children.OfType<Label>())
            {
                labelist.Add(lab);
            }
            PBdockpanel.Children.Clear();
            PhongBan pb = new PhongBan();
            pb.initPhongbanpage(user_bus.getpb(labelist[0].Content.ToString()));
            PBdockpanel.Children.Add(pb);
            addpbbtn.Visibility = Visibility.Hidden;
        }

        private void addpbbtn_Click(object sender, RoutedEventArgs e)
        {
            ThemPhongBan inst = new ThemPhongBan();
            inst.Show();
        }
    }
}
