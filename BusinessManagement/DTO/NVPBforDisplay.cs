namespace DTO
{
    public class NVPBforDisplay
    {
        public string manv { get; set; }
        public string tennv { get; set; }
        public string chucvu { get; set; }
        public long luongnv { get; set; }
        public NVPBforDisplay() { }
        public NVPBforDisplay(string nManv, string nTennv, string nChucvu, long nLuongnv)
        {
            manv = nManv;
            tennv = nTennv;
            chucvu = nChucvu;
            luongnv = nLuongnv;
        }
    }
}
