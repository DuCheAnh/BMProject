using DAL;
using DTO;
using System.Collections.Generic;
namespace BUS
{
    public class BUS_USER
    {
        DAL_User user_func = new DAL_User();
        DAL_NhanVien nhanvien_func = new DAL_NhanVien();
        List<string> random = new List<string>();
        public UserData loginchecker(string sUsername, string sPassword)
        {
            foreach (UserData data in user_func.getall_user())
            {
                if (data.taikhoan == sUsername)
                {
                    if (data.matkhau == sPassword)
                    {
                        CurrentUser.user=data;
                        CurrentUser.nhanvien = nhanvien_func.get_NV(data.NVID);
                        return data;
                    }
                }
            }
            return null;
        }
        public UserData get_user_from_id(string nUid)
        {
            return user_func.get_user(nUid);
        }
        public Nhanvien get_nv_from_id(string nNVID)
        {
            return nhanvien_func.get_NV(nNVID);
        }
    }
}
