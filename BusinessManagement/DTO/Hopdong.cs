namespace DTO
{
    public class Hopdong
    {
        public string HopdongID { get; set; }
        public string tenhopdong { get; set; }
        public string chitiethopdong { get; set; }
        public long luongtoithieu { get; set; }
        public Hopdong() { }
        public Hopdong(string nHopdongID, string nTenhopdong, string nChitiethopdong, long nLuongtoithieu)
        {
            HopdongID = nHopdongID;
            tenhopdong = nTenhopdong;
            chitiethopdong = nChitiethopdong;
            luongtoithieu = nLuongtoithieu;
        }
    }
}
