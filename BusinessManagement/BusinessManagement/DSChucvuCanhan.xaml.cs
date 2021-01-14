using DTO;
using System.Collections.Generic;
using System.Windows;
namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for DSChucvuCanhan.xaml
    /// </summary>
    public partial class DSChucvuCanhan : Window
    {
        public DSChucvuCanhan()
        {
            InitializeComponent();
        }
        public void initdata(CTChucVu data)
        {
            List<CTChucVu> list = new List<CTChucVu>();
            int i = 0;
            int j = 0;
            string subcv = null;
            string subdate = null;
            int counter = 0;
            while (data.ChucvuID.Length > i + 1)
            {
                CTChucVu inst = new CTChucVu();
          
                if (data.NgayUpdate[j] == '-')
                {
                    i++;
                    j++;
                }
                while (data.ChucvuID[i] != '/')
                {
                    subcv += data.ChucvuID[i];
                    i++;
                }
                while (data.NgayUpdate[j] != '-')
                {
                    subdate += data.NgayUpdate[j];
                    j++;
                }
                counter++;
                inst.CTChucvuID = counter.ToString();
                inst.ChucvuID = subcv;
                inst.NgayUpdate = subdate;
                subcv = null;
                subdate = null;
                list.Add(inst);
            }
            cvlistview.ItemsSource = list;
        }
    }
}
