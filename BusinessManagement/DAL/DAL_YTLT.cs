using DTO;
using FireSharp.Response;
using System;
using System.Collections.Generic;
namespace DAL
{
    public class DAL_YTLT
    {
        string db_path = "YCLT/";
        public bool add_YCLT(string nQLID, string nNVID, int nSogiolamthem, int nThang)
        {
            var data = new Yeucaulamthem(nQLID, nNVID, nSogiolamthem, nThang);
            SetResponse rep = DB_connect.client.Set(db_path + DateTime.Now.ToString(), data);
            Yeucaulamthem result = rep.ResultAs<Yeucaulamthem>();
            if (result != null) return true;
            else return false;
        }

        public bool update_YCLT(string nQLID, string nNVID, int nSogiolamthem, int nThang)
        {
            var data = new Yeucaulamthem(nQLID, nNVID, nSogiolamthem, nThang);
            FirebaseResponse rep = DB_connect.client.Update(db_path + DateTime.Now.ToString(), data);
            Yeucaulamthem result = rep.ResultAs<Yeucaulamthem>();
            if (result != null) return true;
            else return false;
        }

        public Yeucaulamthem get_YCLT(string ID)
        {
            var rep = DB_connect.client.Get(db_path + ID);
            if (rep.Body != "null")
            {
                Yeucaulamthem data = rep.ResultAs<Yeucaulamthem>();
                return data;
            }
            else return null;
        }

        public bool remove_YCLT(string ID)
        {
            var usr = DB_connect.client.Get(db_path + ID);
            if (usr.Body != "null")
            {
                FirebaseResponse rep = DB_connect.client.Delete(db_path + ID);
                return true;
            }
            else return false;
        }

        public List<Yeucaulamthem> getall_YCLT()
        {
            List<Yeucaulamthem> list = new List<Yeucaulamthem>();
            FirebaseResponse rep = DB_connect.client.Get(db_path);
            if (rep.Body != "null")
            {
                Dictionary<string, Yeucaulamthem> alldata = new Dictionary<string, Yeucaulamthem>();
                alldata = rep.ResultAs<Dictionary<string, Yeucaulamthem>>();
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
