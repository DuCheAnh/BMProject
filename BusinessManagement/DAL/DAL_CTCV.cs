using DTO;
using FireSharp.Response;
using System.Collections.Generic;
namespace DAL
{
    public class DAL_CTCV
    {
        string db_path = "CTCV/";
        public bool add_CTCV(string nCTChucvuID, string nChucvuID, string nNgayUpdate)
        {
            var data = new CTChucVu(nCTChucvuID, nChucvuID, nNgayUpdate);
            SetResponse rep = DB_connect.client.Set(db_path + nCTChucvuID, data);
            CTChucVu result = rep.ResultAs<CTChucVu>();
            if (result != null) return true;
            else return false;
        }

        public bool update_CTCV(string nCTChucvuID, string nChucvuID, string nNgayUpdate)
        {
            var data = new CTChucVu(nCTChucvuID, nChucvuID, nNgayUpdate);
            FirebaseResponse rep = DB_connect.client.Update(db_path + nCTChucvuID, data);
            CTChucVu result = rep.ResultAs<CTChucVu>();
            if (result != null) return true;
            else return false;
        }

        public CTChucVu get_CTCV(string nCTChucvuID)
        {
            var rep = DB_connect.client.Get(db_path + nCTChucvuID);
            if (rep.Body != "null")
            {
                CTChucVu data = rep.ResultAs<CTChucVu>();
                return data;
            }
            else return null;
        }

        public bool remove_CTCV(string nCTChucvuID)
        {
            var usr = DB_connect.client.Get(db_path + nCTChucvuID);
            if (usr.Body != "null")
            {
                FirebaseResponse rep = DB_connect.client.Delete(db_path + nCTChucvuID);
                return true;
            }
            else return false;
        }

        public List<CTChucVu> getall_CTCV()
        {
            List<CTChucVu> list = new List<CTChucVu>();
            FirebaseResponse rep = DB_connect.client.Get(db_path);
            if (rep.Body != "null")
            {
                Dictionary<string, CTChucVu> alldata = new Dictionary<string, CTChucVu>();
                alldata = rep.ResultAs<Dictionary<string, CTChucVu>>();
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
