using System;
namespace DTO
{
    public class UserData
    {
        public string uid { get; set; }
        public string taikhoan { get; set; }
        public string matkhau { get; set; }
        public string CreatedDate { get; set; }
        public UserData() { }
        public UserData(string nUid, string nTaikhoan, string nMatkhau)
        {
            uid = nUid;
            taikhoan = nTaikhoan;
            matkhau = nMatkhau;
            CreatedDate = DateTime.Now.ToString();
        }
    }
}
