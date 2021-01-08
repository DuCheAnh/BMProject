using DTO;
using FireSharp.Response;
using System.Collections.Generic;
namespace DAL
{
    public class DAL_DSKyNang
    {
        string db_path = "DSKyNang/";
        public bool add_DSKyNang(string nDSKynangID, string nTenkynang, string nMucdo, string nNgaydanhgia)
        {
            var data = new DSKynang(nDSKynangID, nTenkynang, nMucdo, nNgaydanhgia);
            SetResponse rep = DB_connect.client.Set(db_path + nDSKynangID, data);
            DSKynang result = rep.ResultAs<DSKynang>();
            if (result != null) return true;
            else return false;
        }

        public bool update_DSKyNang(string nDSKynangID, string nTenkynang, string nMucdo, string nNgaydanhgia)
        {
            var data = new DSKynang(nDSKynangID, nTenkynang, nMucdo, nNgaydanhgia);
            FirebaseResponse rep = DB_connect.client.Update(db_path + nDSKynangID, data);
            DSKynang result = rep.ResultAs<DSKynang>();
            if (result != null) return true;
            else return false;
        }

        public DSKynang get_DSKyNang(string nDSKynangID)
        {
            var rep = DB_connect.client.Get(db_path + nDSKynangID);
            if (rep.Body != "null")
            {
                DSKynang data = rep.ResultAs<DSKynang>();
                return data;
            }
            else return null;
        }

        public bool remove_DSKyNang(string nDSKynangID)
        {
            var usr = DB_connect.client.Get(db_path + nDSKynangID);
            if (usr.Body != "null")
            {
                FirebaseResponse rep = DB_connect.client.Delete(db_path + nDSKynangID);
                return true;
            }
            else return false;
        }

        public List<DSKynang> getall_DSKyNang()
        {
            List<DSKynang> list = new List<DSKynang>();
            FirebaseResponse rep = DB_connect.client.Get(db_path);
            if (rep.Body != "null")
            {
                Dictionary<string, DSKynang> alldata = new Dictionary<string, DSKynang>();
                alldata = rep.ResultAs<Dictionary<string, DSKynang>>();
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
