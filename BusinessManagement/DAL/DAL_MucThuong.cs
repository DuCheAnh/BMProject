using DTO;
using FireSharp.Response;
using System.Collections.Generic;
namespace DAL
{
    public class DAL_MucThuong
    {
        string db_path = "MucThuong/";
        public bool add_MucThuong(string nMucthuongID, string nTenmucthuong, int nThuong)
        {
            var data = new Mucthuong(nMucthuongID, nTenmucthuong, nThuong);
            SetResponse rep = DB_connect.client.Set(db_path + nMucthuongID, data);
            Mucthuong result = rep.ResultAs<Mucthuong>();
            if (result != null) return true;
            else return false;
        }

        public bool update_MucThuong(string nMucthuongID, string nTenmucthuong, int nThuong)
        {
            var data = new Mucthuong(nMucthuongID, nTenmucthuong, nThuong);
            FirebaseResponse rep = DB_connect.client.Update(db_path + nMucthuongID, data);
            Mucthuong result = rep.ResultAs<Mucthuong>();
            if (result != null) return true;
            else return false;
        }

        public Mucthuong get_MucThuong(string nMucthuongID)
        {
            var rep = DB_connect.client.Get(db_path + nMucthuongID);
            if (rep.Body != "null")
            {
                Mucthuong data = rep.ResultAs<Mucthuong>();
                return data;
            }
            else return null;
        }

        public bool remove_MucThuong(string nMucthuongID)
        {
            var usr = DB_connect.client.Get(db_path + nMucthuongID);
            if (usr.Body != "null")
            {
                FirebaseResponse rep = DB_connect.client.Delete(db_path + nMucthuongID);
                return true;
            }
            else return false;
        }

        public List<Mucthuong> getall_MucThuong()
        {
            List<Mucthuong> list = new List<Mucthuong>();
            FirebaseResponse rep = DB_connect.client.Get(db_path);
            if (rep.Body != "null")
            {
                Dictionary<string, Mucthuong> alldata = new Dictionary<string, Mucthuong>();
                alldata = rep.ResultAs<Dictionary<string, Mucthuong>>();
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
