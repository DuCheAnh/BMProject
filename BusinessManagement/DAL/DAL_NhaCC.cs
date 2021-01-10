using DTO;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Collections.Generic;
using System;
namespace DAL
{
    public class DAL_NhaCC
    {
        string db_path = "NhaCC/";
        public IFirebaseClient client;
        public bool add_NhaCC(string nNhaccID, string nTennhacc, string nSdt)
        {
            var data = new Nhacc(nNhaccID, nTennhacc, nSdt);
            SetResponse rep = DB_connect.client.Set(db_path + nNhaccID, data);
            Nhacc result = rep.ResultAs<Nhacc>();
            if (result != null) return true;
            else return false;
        }

        public bool update_NhaCC(string nNhaccID, string nTennhacc, string nSdt)
        {
            var data = new Nhacc(nNhaccID, nTennhacc, nSdt);
            FirebaseResponse rep = DB_connect.client.Update(db_path + nNhaccID, data);
            Nhacc result = rep.ResultAs<Nhacc>();
            if (result != null) return true;
            else return false;
        }

        public Nhacc get_NhaCC(string nNhaccID)
        {
            var rep = DB_connect.client.Get(db_path + nNhaccID);
            if (rep.Body != "null")
            {
                Nhacc data = rep.ResultAs<Nhacc>();
                return data;
            }
            else return null;
        }

        public bool remove_NhaCC(string nNhaccID)
        {
            var usr = DB_connect.client.Get(db_path + nNhaccID);
            if (usr.Body != "null")
            {
                FirebaseResponse rep = DB_connect.client.Delete(db_path + nNhaccID);
                return true;
            }
            else return false;
        }

        public List<Nhacc> getall_NhaCC()
        {
            List<Nhacc> list = new List<Nhacc>();
            FirebaseResponse rep = DB_connect.client.Get(db_path);
            if (rep.Body != "null")
            {
                Dictionary<string, Nhacc> alldata = new Dictionary<string, Nhacc>();
                alldata = rep.ResultAs<Dictionary<string, Nhacc>>();
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
