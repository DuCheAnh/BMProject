namespace DTO
{
    public class Yeucaulamthem
    {
        public string QLID { get; set; }
        public string NVID { get; set; }
        public int sogiolamthem { get; set; }
        public int thang { get; set; }
        public Yeucaulamthem() { }
        public Yeucaulamthem(string nQLID, string nNVID, int nSogiolamthem, int nThang)
        {
            QLID = nQLID;
            NVID = nNVID;
            sogiolamthem = nSogiolamthem;
            thang = nThang;
        }
    }
}
