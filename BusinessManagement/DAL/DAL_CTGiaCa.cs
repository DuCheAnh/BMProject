using DTO;
using FireSharp.Response;
using System.Collections.Generic;
namespace DAL
{
    public class DAL_CTGiaCa
    {
        string db_path = "CTGiaCa/";
        public bool add_CTGiaCa(string nCTGiacaID, long nGiaca, string nNgayUpdate)
        {
            var data = new CTGiaca(nCTGiacaID, nGiaca, nNgayUpdate);
            SetResponse rep = DB_connect.client.Set(db_path + nCTGiacaID, data);
            CTGiaca result = rep.ResultAs<CTGiaca>();
            if (result != null) return true;
            else return false;
        }

        public bool update_CTGiaCa(string nCTGiacaID, long nGiaca, string nNgayUpdate)
        {
            var data = new CTGiaca(nCTGiacaID, nGiaca, nNgayUpdate);
            FirebaseResponse rep = DB_connect.client.Update(db_path + nCTGiacaID, data);
            CTGiaca result = rep.ResultAs<CTGiaca>();
            if (result != null) return true;
            else return false;
        }

        public CTGiaca get_CTGiaCa(string nCTGiacaID)
        {
            var rep = DB_connect.client.Get(db_path + nCTGiacaID);
            if (rep.Body != "null")
            {
                CTGiaca data = rep.ResultAs<CTGiaca>();
                return data;
            }
            else return null;
        }

        public bool remove_CTGiaCa(string nCTGiacaID)
        {
            var usr = DB_connect.client.Get(db_path + nCTGiacaID);
            if (usr.Body != "null")
            {
                FirebaseResponse rep = DB_connect.client.Delete(db_path + nCTGiacaID);
                return true;
            }
            else return false;
        }

        public List<CTGiaca> getall_CTGiaCa()
        {
            List<CTGiaca> list = new List<CTGiaca>();
            FirebaseResponse rep = DB_connect.client.Get(db_path);
            if (rep.Body != "null")
            {
                Dictionary<string, CTGiaca> alldata = new Dictionary<string, CTGiaca>();
                alldata = rep.ResultAs<Dictionary<string, CTGiaca>>();
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
