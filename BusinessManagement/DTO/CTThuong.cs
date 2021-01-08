namespace DTO
{
    public class CTThuong
    {
        public string CTThuongID { get; set; }
        public string MucthuongID { get; set; }
        public int thang { get; set; }
        public CTThuong() { }
        public CTThuong(string nCTThuongID, string nMucthuongID, int nThang)
        {
            CTThuongID = nCTThuongID;
            MucthuongID = nMucthuongID;
            thang = nThang;
        }
    }
}
