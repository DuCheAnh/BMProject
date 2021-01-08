namespace DTO
{
    public class CTKyket
    {
        public string CTKyketID { get; set; }
        public string HopdongID { get; set; }
        public long luongkyket { get; set; }
        public string ngaybd { get; set; }
        public string ngaykt { get; set; }
        public CTKyket() { }
        public CTKyket(string nCTKyketID, string nHopdongID, long nLuongkyket, string nNgaybd, string nNgaykt)
        {
            CTKyketID = nCTKyketID;
            HopdongID = nHopdongID;
            luongkyket = nLuongkyket;
            ngaybd = nNgaybd;
            ngaykt = nNgaykt;
        }
    }

}
