using DTO;
using FireSharp.Response;
using System.Collections.Generic;
namespace DAL
{
    public class DAL_KyKet
    {
        string db_path = "CTKyKet/";
        public bool add_CTKyKet(string nCTKyketID, string nHopdongID, long nLuongkyket, string nNgaybd, string nNgaykt)
        {
            var data = new CTKyket(nCTKyketID, nHopdongID, nLuongkyket, nNgaybd, nNgaykt);
            SetResponse rep = DB_connect.client.Set(db_path + nCTKyketID, data);
            CTKyket result = rep.ResultAs<CTKyket>();
            if (result != null) return true;
            else return false;
        }

        public bool update_CTKyKet(string nCTKyketID, string nHopdongID, long nLuongkyket, string nNgaybd, string nNgaykt)
        {
            var data = new CTKyket(nCTKyketID, nHopdongID, nLuongkyket, nNgaybd, nNgaykt);
            FirebaseResponse rep = DB_connect.client.Update(db_path + nCTKyketID, data);
            CTKyket result = rep.ResultAs<CTKyket>();
            if (result != null) return true;
            else return false;
        }

        public CTKyket get_CTKyKet(string nCTKyketID)
        {
            var rep = DB_connect.client.Get(db_path + nCTKyketID);
            if (rep.Body != "null")
            {
                CTKyket data = rep.ResultAs<CTKyket>();
                return data;
            }
            else return null;
        }

        public bool remove_CTKyKet(string nCTKyketID)
        {
            var usr = DB_connect.client.Get(db_path + nCTKyketID);
            if (usr.Body != "null")
            {
                FirebaseResponse rep = DB_connect.client.Delete(db_path + nCTKyketID);
                return true;
            }
            else return false;
        }

        public List<CTKyket> getall_CTKyKet()
        {
            List<CTKyket> list = new List<CTKyket>();
            FirebaseResponse rep = DB_connect.client.Get(db_path);
            if (rep.Body != "null")
            {
                Dictionary<string, CTKyket> alldata = new Dictionary<string, CTKyket>();
                alldata = rep.ResultAs<Dictionary<string, CTKyket>>();
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
