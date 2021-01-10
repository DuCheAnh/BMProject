using DAL;
using DTO;
using System.Collections.Generic;
namespace BUS
{
    public class BUS_USER
    {
        List<string> random = new List<string>();
        public UserData get_user_from_id(string nUid)
        {
            DAL_User user_func = new DAL_User();
            return user_func.get_user(nUid);
        }
        public Nhanvien get_nv_from_id(string nNVID)
        {
            DAL_NhanVien nhanvien_func = new DAL_NhanVien();
            return nhanvien_func.get_NV(nNVID);
        }
    }
}
