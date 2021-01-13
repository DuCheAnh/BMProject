using DTO;
using FireSharp.Response;
using System.Collections.Generic;
namespace DAL
{
    public class DAL_KhachHang
    {
        string db_path = "KhachHang/";
        public bool add_KhachHang(string nKhachhangID, string nTenkh, string nSdt, string nDiachi)
        {
            var data = new Khachhang(nKhachhangID, nTenkh, nSdt, nDiachi);
            SetResponse rep = DB_connect.client.Set(db_path + nKhachhangID, data);
            Khachhang result = rep.ResultAs<Khachhang>();
            if (result != null) return true;
            else return false;
        }

        public bool update_KhachHang(string nKhachhangID, string nTenkh, string nSdt, string nDiachi)
        {
            var data = new Khachhang(nKhachhangID, nTenkh, nSdt, nDiachi);
            FirebaseResponse rep = DB_connect.client.Update(db_path + nKhachhangID, data);
            Khachhang result = rep.ResultAs<Khachhang>();
            if (result != null) return true;
            else return false;
        }

        public Khachhang get_KhachHang(string nKhachhangID)
        {
            var rep = DB_connect.client.Get(db_path + nKhachhangID);
            if (rep.Body != "null")
            {
                Khachhang data = rep.ResultAs<Khachhang>();
                return data;
            }
            else return null;
        }

        public bool remove_KhachHang(string nKhachhangID)
        {
            var usr = DB_connect.client.Get(db_path + nKhachhangID);
            if (usr.Body != "null")
            {
                FirebaseResponse rep = DB_connect.client.Delete(db_path + nKhachhangID);
                return true;
            }
            else return false;
        }

        public List<Khachhang> getall_KhachHang()
        {
            List<Khachhang> list = new List<Khachhang>();
            FirebaseResponse rep = DB_connect.client.Get(db_path);
            if (rep.Body != "null")
            {
                Dictionary<string, Khachhang> alldata = new Dictionary<string, Khachhang>();
                alldata = rep.ResultAs<Dictionary<string, Khachhang>>();
                foreach (var data in alldata)
                {
                    list.Add(data.Value);
                }
                return list;
            }
            else return null;
        }
        public int new_KhachHangID()
        {
            var rep = DB_connect.client.Get("Counter/KHCounter");
            NumberCounter data = rep.ResultAs<NumberCounter>();
            data.value += 1;
            SetResponse res = DB_connect.client.Set("Counter/KHCounter", data);
            return data.value;
        }
    }
}
