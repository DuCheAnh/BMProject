namespace DTO
{
    public class Mucthuong
    {
        public string MucthuongID { get; set; }
        public string tenmucthuong { get; set; }
        public int thuong { get; set; }
        public Mucthuong() { }
        public Mucthuong(string nMucthuongID, string nTenmucthuong, int nThuong)
        {
            MucthuongID = nMucthuongID;
            tenmucthuong = nTenmucthuong;
            thuong = nThuong;
        }
    }
}
