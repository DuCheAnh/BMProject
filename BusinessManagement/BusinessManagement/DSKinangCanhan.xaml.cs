using DTO;
using System.Collections.Generic;
using System.Windows;
namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for DSKinangCanhan.xaml
    /// </summary>
    public partial class DSKinangCanhan : Window
    {

        public DSKinangCanhan()
        {
            InitializeComponent();
        }
        public void initdata(DSKynang data)
        {
            List<DSKynang> list = new List<DSKynang>();
            int i = 0;
            int j = 0;
            int k = 0;
            string subkn = null;
            string subdate = null;
            string sublel = null;
            int counter = 0;
            while (data.tenkynang.Length > i + 1)
            {
                DSKynang inst = new DSKynang();

                if (data.ngaydanhgia[j] == '-')
                {
                    i++;
                    j++;
                    k++;
                }
                while (data.tenkynang[i] != '/')
                {
                    subkn += data.tenkynang[i];
                    i++;
                }
                while (data.ngaydanhgia[j] != '-')
                {
                    subdate += data.ngaydanhgia[j];
                    j++;
                }
                while (data.mucdo[k] != '/')
                {
                    sublel += data.mucdo[k];
                    k++;
                }
                counter++;
                inst.DSKynangID = counter.ToString();
                inst.tenkynang = subkn;
                inst.ngaydanhgia = subdate;
                inst.mucdo = sublel;
                subkn = null;
                subdate = null;
                sublel = null;
                list.Add(inst);
            }
            knlistview.ItemsSource = list;
        }
    }
}
