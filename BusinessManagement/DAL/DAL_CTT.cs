using DTO;
using FireSharp.Response;
using System.Collections.Generic;
namespace DAL
{
    public class DAL_CTT
    {
        string db_path = "CTThuong/";
        public bool add_CTThuong(string nCTThuongID, string nMucthuongID, int nThang)
        {
            var data = new CTThuong(nCTThuongID, nMucthuongID, nThang);
            SetResponse rep = DB_connect.client.Set(db_path + nCTThuongID, data);
            CTThuong result = rep.ResultAs<CTThuong>();
            if (result != null) return true;
            else return false;
        }

        public bool update_CTThuong(string nCTThuongID, string nMucthuongID, int nThang)
        {
            var data = new CTThuong(nCTThuongID, nMucthuongID, nThang);
            FirebaseResponse rep = DB_connect.client.Update(db_path + nCTThuongID, data);
            CTThuong result = rep.ResultAs<CTThuong>();
            if (result != null) return true;
            else return false;
        }

        public CTThuong get_CTThuong(string nCTThuongID)
        {
            var rep = DB_connect.client.Get(db_path + nCTThuongID);
            if (rep.Body != "null")
            {
                CTThuong data = rep.ResultAs<CTThuong>();
                return data;
            }
            else return null;
        }

        public bool remove_CTT(string nCTThuongID)
        {
            var usr = DB_connect.client.Get(db_path + nCTThuongID);
            if (usr.Body != "null")
            {
                FirebaseResponse rep = DB_connect.client.Delete(db_path + nCTThuongID);
                return true;
            }
            else return false;
        }

        public List<CTThuong> getall_CTT()
        {
            List<CTThuong> list = new List<CTThuong>();
            FirebaseResponse rep = DB_connect.client.Get(db_path);
            if (rep.Body != "null")
            {
                Dictionary<string, CTThuong> alldata = new Dictionary<string, CTThuong>();
                alldata = rep.ResultAs<Dictionary<string, CTThuong>>();
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
