using DTO;
using FireSharp.Response;
using System.Collections.Generic;
namespace DAL
{
    public class DAL_User
    {
        string db_path = "User/";
        public bool add_user(string nUid, string nTaikhoan, string nMatkhau, string nNVID, string nPBID)
        {
            var data = new UserData(nUid, nTaikhoan, nMatkhau, nNVID, nPBID);
            SetResponse rep = DB_connect.client.Set(db_path + nUid, data);
            UserData result = rep.ResultAs<UserData>();
            if (result != null) return true;
            else return false;
        }

        public bool update_user(string nUid, string nTaikhoan, string nMatkhau, string nNVID, string nPBID)
        {
            var data = new UserData(nUid, nTaikhoan, nMatkhau, nNVID, nPBID);
            FirebaseResponse rep = DB_connect.client.Update(db_path + nUid, data);
            UserData result = rep.ResultAs<UserData>();
            if (result != null) return true;
            else return false;
        }

        public UserData get_user(string nUid)
        {
            var rep = DB_connect.client.Get(db_path + nUid);
            if (rep.Body != "null")
            {
                UserData data = rep.ResultAs<UserData>();
                return data;
            }
            else return null;
        }

        public bool remove_user(string nUid)
        {
            var usr = DB_connect.client.Get(db_path + nUid);
            if (usr.Body != "null")
            {
                FirebaseResponse rep = DB_connect.client.Delete(db_path + nUid);
                return true;
            }
            else return false;
        }

        public List<UserData> getall_user()
        {
            List<UserData> list = new List<UserData>();
            FirebaseResponse rep = DB_connect.client.Get(db_path);
            if (rep.Body != "null")
            {
                Dictionary<string, UserData> alldata = new Dictionary<string, UserData>();
                alldata = rep.ResultAs<Dictionary<string, UserData>>();
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
