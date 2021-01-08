namespace DTO
{
    public class PBData
    {
        public string PBID { get; set; }
        public string tenpb { get; set; }
        public string sdt { get; set; }
        public string email { get; set; }
        public string QLID { get; set; }
        public string NVID { get; set; }
        public PBData()
        {
        }
        public PBData(string nPBID, string nTenpb, string nSdt, string nEmail, string nQLID, string nNVID)
        {
            PBID = nPBID;
            tenpb = nTenpb;
            sdt = nSdt;
            email = nEmail;
            QLID = nQLID;
            NVID = nNVID;
        }
    }
}
