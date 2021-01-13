using DTO;
using FireSharp.Response;
using System.Collections.Generic;
namespace DAL
{
    public class DAL_NhanVien
    {
        string db_path = "NhanVien/";
        public bool add_NV(string nNVID, string nType, string nTennv, string nEmail, string nNgaysinh, string nGioitinh,
            string nNoisinh, string nDiachi, string nTrinhdo, string nPBID, string nCTChucvuID, string nCTLamthemID, string nCTThuongID, string nCTKyketID, string nDSKinangID)
        {
            var data = new Nhanvien(nNVID, nType, nTennv, nEmail, nNgaysinh, nGioitinh, nNoisinh, nDiachi, nTrinhdo, nPBID, nCTChucvuID, nCTLamthemID,
                                    nCTThuongID, nCTKyketID, nDSKinangID);
            SetResponse rep = DB_connect.client.Set(db_path + nNVID, data);
            Nhanvien result = rep.ResultAs<Nhanvien>();
            if (result != null) return true;
            else return false;
        }

        public bool update_NV(string nNVID, string nType, string nTennv, string nEmail, string nNgaysinh, string nGioitinh,
            string nNoisinh, string nDiachi, string nTrinhdo, string nPBID, string nCTChucvuID, string nCTLamthemID, string nCTThuongID, string nCTKyketID, string nDSKinangID)
        {
            var data = new Nhanvien(nNVID, nType, nTennv, nEmail, nNgaysinh, nGioitinh, nNoisinh, nDiachi, nTrinhdo, nPBID, nCTChucvuID, nCTLamthemID,
                                    nCTThuongID, nCTKyketID, nDSKinangID);
            FirebaseResponse rep = DB_connect.client.Update(db_path + nNVID, data);
            Nhanvien result = rep.ResultAs<Nhanvien>();
            if (result != null) return true;
            else return false;
        }

        public Nhanvien get_NV(string nNVID)
        {
            var rep = DB_connect.client.Get(db_path + nNVID);
            if (rep.Body != "null")
            {
                Nhanvien data = rep.ResultAs<Nhanvien>();
                return data;
            }
            else return null;
        }

        public bool remove_NV(string nNVID)
        {
            var usr = DB_connect.client.Get(db_path + nNVID);
            if (usr.Body != "null")
            {
                FirebaseResponse rep = DB_connect.client.Delete(db_path + nNVID);
                return true;
            }
            else return false;
        }

        public List<Nhanvien> getall_NV()
        {
            List<Nhanvien> list = new List<Nhanvien>();
            FirebaseResponse rep = DB_connect.client.Get(db_path);
            if (rep.Body != "null")
            {
                Dictionary<string, Nhanvien> alldata = new Dictionary<string, Nhanvien>();
                alldata = rep.ResultAs<Dictionary<string, Nhanvien>>();
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
