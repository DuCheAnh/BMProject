using DTO;
using FireSharp.Response;
using System.Collections.Generic;
namespace DAL
{
    public class DAL_HoaDon
    {
        string db_path = "HoaDon/";
        public bool add_HoaDon(string nHoadonID, string nDonhangID, string nNgaylap, string nNgayxuat, string nNhanvienID
            , string nKhachhangID)
        {
            var data = new Hoadon(nHoadonID, nDonhangID, nNgaylap, nNgayxuat, nNhanvienID, nKhachhangID);
            SetResponse rep = DB_connect.client.Set(db_path + nHoadonID, data);
            Hoadon result = rep.ResultAs<Hoadon>();
            if (result != null) return true;
            else return false;
        }

        public bool update_HoaDon(string nHoadonID, string nDonhangID, string nNgaylap, string nNgayxuat, string nNhanvienID
            , string nKhachhangID)
        {
            var data = new Hoadon(nHoadonID, nDonhangID, nNgaylap, nNgayxuat, nNhanvienID, nKhachhangID);
            FirebaseResponse rep = DB_connect.client.Update(db_path + nHoadonID, data);
            Hoadon result = rep.ResultAs<Hoadon>();
            if (result != null) return true;
            else return false;
        }

        public Hoadon get_HoaDon(string nHoadonID)
        {
            var rep = DB_connect.client.Get(db_path + nHoadonID);
            if (rep.Body != "null")
            {
                Hoadon data = rep.ResultAs<Hoadon>();
                return data;
            }
            else return null;
        }

        public bool remove_HoaDon(string nHoadonID)
        {
            var usr = DB_connect.client.Get(db_path + nHoadonID);
            if (usr.Body != "null")
            {
                FirebaseResponse rep = DB_connect.client.Delete(db_path + nHoadonID);
                return true;
            }
            else return false;
        }

        public List<Hoadon> getall_HoaDon()
        {
            List<Hoadon> list = new List<Hoadon>();
            FirebaseResponse rep = DB_connect.client.Get(db_path);
            if (rep.Body != "null")
            {
                Dictionary<string, Hoadon> alldata = new Dictionary<string, Hoadon>();
                alldata = rep.ResultAs<Dictionary<string, Hoadon>>();
                foreach (var data in alldata)
                {
                    list.Add(data.Value);
                }
                return list;
            }
            else return null;
        }
    }
}
