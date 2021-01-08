using DTO;
using FireSharp.Response;
using System.Collections.Generic;
namespace DAL
{
    public class DAL_ChucVu
    {
        string db_path = "ChucVu/";
        public bool add_CV(string nChucvuID, string nTenchucvu, long nThuongchucvu)
        {
            var data = new Chucvu(nChucvuID, nTenchucvu, nThuongchucvu);
            SetResponse rep = DB_connect.client.Set(db_path + nChucvuID, data);
            Chucvu result = rep.ResultAs<Chucvu>();
            if (result != null) return true;
            else return false;
        }

        public bool update_CV(string nChucvuID, string nTenchucvu, long nThuongchucvu)
        {
            var data = new Chucvu(nChucvuID, nTenchucvu, nThuongchucvu);
            FirebaseResponse rep = DB_connect.client.Update(db_path + nChucvuID, data);
            Chucvu result = rep.ResultAs<Chucvu>();
            if (result != null) return true;
            else return false;
        }

        public Chucvu get_CV(string nChucvuID)
        {
            var rep = DB_connect.client.Get(db_path + nChucvuID);
            if (rep.Body != "null")
            {
                Chucvu data = rep.ResultAs<Chucvu>();
                return data;
            }
            else return null;
        }

        public bool remove_CV(string nChucvuID)
        {
            var usr = DB_connect.client.Get(db_path + nChucvuID);
            if (usr.Body != "null")
            {
                FirebaseResponse rep = DB_connect.client.Delete(db_path + nChucvuID);
                return true;
            }
            else return false;
        }

        public List<Chucvu> getall_CV()
        {
            List<Chucvu> list = new List<Chucvu>();
            FirebaseResponse rep = DB_connect.client.Get(db_path);
            if (rep.Body != "null")
            {
                Dictionary<string, Chucvu> alldata = new Dictionary<string, Chucvu>();
                alldata = rep.ResultAs<Dictionary<string, Chucvu>>();
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
