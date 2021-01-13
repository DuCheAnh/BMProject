using DTO;
using FireSharp.Response;
using System.Collections.Generic;
namespace DAL
{
    public class DAL_HangHoa
    {
        string db_path = "HangHoa/";
        public bool add_HangHoa(string nHanghoaID, string nTenhh, string nNhomhang,
                                string nDvt, string nNhaccID, string nCTGiacaID)
        {
            var data = new Hanghoa(nHanghoaID, nTenhh, nNhomhang, nDvt, nNhaccID, nCTGiacaID);
            SetResponse rep = DB_connect.client.Set(db_path + nHanghoaID, data);
            Hanghoa result = rep.ResultAs<Hanghoa>();
            if (result != null) return true;
            else return false;
        }

        public bool update_HangHoa(string nHanghoaID, string nTenhh, string nNhomhang,
                                string nDvt, string nNhaccID, string nCTGiacaID)
        {
            var data = new Hanghoa(nHanghoaID, nTenhh, nNhomhang, nDvt, nNhaccID, nCTGiacaID);
            FirebaseResponse rep = DB_connect.client.Update(db_path + nHanghoaID, data);
            Hanghoa result = rep.ResultAs<Hanghoa>();
            if (result != null) return true;
            else return false;
        }

        public Hanghoa get_HangHoa(string nHanghoaID)
        {
            var rep = DB_connect.client.Get(db_path + nHanghoaID);
            if (rep.Body != "null")
            {
                Hanghoa data = rep.ResultAs<Hanghoa>();
                return data;
            }
            else return null;
        }

        public bool remove_HangHoa(string nHanghoaID)
        {
            var usr = DB_connect.client.Get(db_path + nHanghoaID);
            if (usr.Body != "null")
            {
                FirebaseResponse rep = DB_connect.client.Delete(db_path + nHanghoaID);
                return true;
            }
            else return false;
        }

        public List<Hanghoa> getall_HangHoa()
        {
            List<Hanghoa> list = new List<Hanghoa>();
            FirebaseResponse rep = DB_connect.client.Get(db_path);
            if (rep.Body != "null")
            {
                Dictionary<string, Hanghoa> alldata = new Dictionary<string, Hanghoa>();
                alldata = rep.ResultAs<Dictionary<string, Hanghoa>>();
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
