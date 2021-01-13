using DTO;
using FireSharp.Response;
using System.Collections.Generic;
namespace DAL
{
    public class DAL_CTLT
    {
        string db_path = "CTLT/";
        public bool add_CTLT(string nCTLamthemID, float nSogiolamthem, int nThang)
        {
            var data = new CTLamthem(nCTLamthemID, nSogiolamthem, nThang);
            SetResponse rep = DB_connect.client.Set(db_path + nCTLamthemID, data);
            CTLamthem result = rep.ResultAs<CTLamthem>();
            if (result != null) return true;
            else return false;
        }

        public bool update_CTLT(string nCTLamthemID, float nSogiolamthem, int nThang,string name)
        {
            var data = new CTLamthem(nCTLamthemID, nSogiolamthem, nThang);
            data.tennv = name;
            FirebaseResponse rep = DB_connect.client.Update(db_path + nCTLamthemID, data);
            CTLamthem result = rep.ResultAs<CTLamthem>();
            if (result != null) return true;
            else return false;
        }

        public CTLamthem get_CTLT(string nCTLamthemID)
        {
            var rep = DB_connect.client.Get(db_path + nCTLamthemID);
            if (rep.Body != "null")
            {
                CTLamthem data = rep.ResultAs<CTLamthem>();
                return data;
            }
            else return null;
        }

        public bool remove_CTLT(string nCTLamthemID)
        {
            var usr = DB_connect.client.Get(db_path + nCTLamthemID);
            if (usr.Body != "null")
            {
                FirebaseResponse rep = DB_connect.client.Delete(db_path + nCTLamthemID);
                return true;
            }
            else return false;
        }
        public bool add_tennv(string nTennv, string nCTlamthemID)
        {
            CTLamthem data = get_CTLT(nCTlamthemID);
            data.tennv = nTennv;
            FirebaseResponse rep = DB_connect.client.Update(db_path + nCTlamthemID, data);
            CTLamthem result = rep.ResultAs<CTLamthem>();
            if (result != null) return true;
            else return false;
        }
        public List<CTLamthem> getall_CTLT()
        {
            List<CTLamthem> list = new List<CTLamthem>();
            FirebaseResponse rep = DB_connect.client.Get(db_path);
            if (rep.Body != "null")
            {
                Dictionary<string, CTLamthem> alldata = new Dictionary<string, CTLamthem>();
                alldata = rep.ResultAs<Dictionary<string, CTLamthem>>();
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
