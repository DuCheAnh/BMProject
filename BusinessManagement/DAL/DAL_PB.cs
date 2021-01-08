using DTO;
using FireSharp.Response;
using System.Collections.Generic;
namespace DAL
{
    public class DAL_PB
    {
        string db_path = "PhongBan/";
        public bool add_PB(string nPBID, string nTenpb, string nSdt, string nEmail, string nQLID, string nNVID)
        {
            var data = new PBData(nPBID, nTenpb, nSdt, nEmail, nQLID, nNVID);
            SetResponse rep = DB_connect.client.Set(db_path + nPBID, data);
            PBData result = rep.ResultAs<PBData>();
            if (result != null) return true;
            else return false;
        }

        public bool update_PB(string nPBID, string nTenpb, string nSdt, string nEmail, string nQLID, string nNVID)
        {
            var data = new PBData(nPBID, nTenpb, nSdt, nEmail, nQLID, nNVID);
            FirebaseResponse rep = DB_connect.client.Update(db_path + nPBID, data);
            PBData result = rep.ResultAs<PBData>();
            if (result != null) return true;
            else return false;
        }

        public PBData get_PB(string nPBID)
        {
            var rep = DB_connect.client.Get(db_path + nPBID);
            if (rep.Body != "null")
            {
                PBData data = rep.ResultAs<PBData>();
                return data;
            }
            else return null;
        }

        public bool remove_PB(string nPBID)
        {
            var usr = DB_connect.client.Get(db_path + nPBID);
            if (usr.Body != "null")
            {
                FirebaseResponse rep = DB_connect.client.Delete(db_path + nPBID);
                return true;
            }
            else return false;
        }

        public List<PBData> getall_PB()
        {
            List<PBData> list = new List<PBData>();
            FirebaseResponse rep = DB_connect.client.Get(db_path);
            if (rep.Body != "null")
            {
                Dictionary<string, PBData> alldata = new Dictionary<string, PBData>();
                alldata = rep.ResultAs<Dictionary<string, PBData>>();
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
