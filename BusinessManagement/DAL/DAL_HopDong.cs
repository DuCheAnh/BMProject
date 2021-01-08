using DTO;
using FireSharp.Response;
using System.Collections.Generic;
namespace DAL
{
    public class DAL_HopDong
    {
        string db_path = "HopDong/";
        public bool add_HopDong(string nHopdongID, string nTenhopdong, string nChitiethopdong, long nLuongtoithieu)
        {
            var data = new Hopdong(nHopdongID, nTenhopdong, nChitiethopdong, nLuongtoithieu);
            SetResponse rep = DB_connect.client.Set(db_path + nHopdongID, data);
            Hopdong result = rep.ResultAs<Hopdong>();
            if (result != null) return true;
            else return false;
        }

        public bool update_HopDong(string nHopdongID, string nTenhopdong, string nChitiethopdong, long nLuongtoithieu)
        {
            var data = new Hopdong(nHopdongID, nTenhopdong, nChitiethopdong, nLuongtoithieu);
            FirebaseResponse rep = DB_connect.client.Update(db_path + nHopdongID, data);
            Hopdong result = rep.ResultAs<Hopdong>();
            if (result != null) return true;
            else return false;
        }

        public Hopdong get_HopDong(string nHopdongID)
        {
            var rep = DB_connect.client.Get(db_path + nHopdongID);
            if (rep.Body != "null")
            {
                Hopdong data = rep.ResultAs<Hopdong>();
                return data;
            }
            else return null;
        }

        public bool remove_HopDong(string nHopdongID)
        {
            var usr = DB_connect.client.Get(db_path + nHopdongID);
            if (usr.Body != "null")
            {
                FirebaseResponse rep = DB_connect.client.Delete(db_path + nHopdongID);
                return true;
            }
            else return false;
        }

        public List<Hopdong> getall_HopDong()
        {
            List<Hopdong> list = new List<Hopdong>();
            FirebaseResponse rep = DB_connect.client.Get(db_path);
            if (rep.Body != "null")
            {
                Dictionary<string, Hopdong> alldata = new Dictionary<string, Hopdong>();
                alldata = rep.ResultAs<Dictionary<string, Hopdong>>();
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
