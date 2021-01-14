using DTO;
using FireSharp.Response;
using System.Collections.Generic;
namespace DAL
{
    public class DAL_DonHang
    {
        string db_path = "DonHang/";
        private long get_trigia(string hhid, string sl)
        {
            int i = 0;
            int j = 0;
            string subhhid = null;
            string subsl = null;
            long result = 0;
            while (hhid.Length>i+1)
            {
                
                if (hhid[i]=='/')
                {
                    i++;
                    j++;
                }
                while (hhid[i]!='/')
                {
                    subhhid += hhid[i];
                    i++;
                }
                while( sl[j]!='/')
                {
                    subsl += sl[j];
                    j++;
                }
                DAL_HangHoa hh_func = new DAL_HangHoa();
                DAL_CTGiaCa giaca_func = new DAL_CTGiaCa();
                result += giaca_func.get_CTGiaCa(hh_func.get_HangHoa(subhhid).CTGiacaID).giaca*long.Parse(subsl);
                subhhid = null;
                subsl = null;
            }

            return result;
        }
        public bool add_DonHang(string nDonhangID, string nHanghoaID, string nNgaythem, string nSoluong, string nKhachhangID)
        {
            var data = new Donhang(nDonhangID, nHanghoaID, nNgaythem, nSoluong, nKhachhangID,get_trigia(nHanghoaID,nSoluong));
            SetResponse rep = DB_connect.client.Set(db_path + nDonhangID, data);
            Donhang result = rep.ResultAs<Donhang>();
            if (result != null) return true;
            else return false;
        }

        public bool update_DonHang(string nDonhangID, string nHanghoaID, string nNgaythem, string nSoluong, string nKhachhangID)
        {
            var data = new Donhang(nDonhangID, nHanghoaID, nNgaythem, nSoluong, nKhachhangID, get_trigia(nHanghoaID, nSoluong));
            FirebaseResponse rep = DB_connect.client.Update(db_path + nDonhangID, data);
            Donhang result = rep.ResultAs<Donhang>();
            if (result != null) return true;
            else return false;
        }

        public Donhang get_DonHang(string nDonhangID)
        {
            var rep = DB_connect.client.Get(db_path + nDonhangID);
            if (rep.Body != "null")
            {
                Donhang data = rep.ResultAs<Donhang>();
                return data;
            }
            else return null;
        }

        public bool remove_DonHang(string nDonhangID)
        {
            var usr = DB_connect.client.Get(db_path + nDonhangID);
            if (usr.Body != "null")
            {
                FirebaseResponse rep = DB_connect.client.Delete(db_path + nDonhangID);
                return true;
            }
            else return false;
        }

        public List<Donhang> getall_DonHang()
        {
            List<Donhang> list = new List<Donhang>();
            FirebaseResponse rep = DB_connect.client.Get(db_path);
            if (rep.Body != "null")
            {
                Dictionary<string, Donhang> alldata = new Dictionary<string, Donhang>();
                alldata = rep.ResultAs<Dictionary<string, Donhang>>();
                foreach (var data in alldata)
                {
                    list.Add(data.Value);
                }
                return list;
            }
            else return null;
        }

        public int new_DonHangID()
        {
            var rep = DB_connect.client.Get("Counter/DHCounter");
            NumberCounter data = rep.ResultAs<NumberCounter>();
            data.value += 1;
            SetResponse res = DB_connect.client.Set("Counter/DHCounter", data);
            return data.value;
        }
    }
}
