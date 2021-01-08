using System;
namespace DTO
{
    public class UserData
    {
        public string uid { get; set; }
        public string taikhoan { get; set; }
        public string matkhau { get; set; }
        public string CreatedDate { get; set; }
        public string NVID { get; set; }
        public string PBID { get; set; }
        public UserData() { }
        public UserData(string nUid, string nTaikhoan, string nMatkhau, string nNVID, string nPBID)
        {
            uid = nUid;
            taikhoan = nTaikhoan;
            matkhau = nMatkhau;
            NVID = nNVID;
            PBID = nPBID;
            CreatedDate = DateTime.Now.ToString();
        }
    }
}
