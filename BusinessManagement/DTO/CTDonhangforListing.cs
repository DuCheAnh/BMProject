namespace DTO
{
    public class CTDonhangforListing
    {
        public string DonhangID { get; set; }
        public string HanghoaID { get; set; }
        public string tenhh { get; set; }
        public string soluong { get; set; }
        public long giaca { get; set; }
        public long thanhtien { get; set; }
        public CTDonhangforListing() { }
        public CTDonhangforListing(string nDonhangID, string nHanghoaID, string nTenhh, string nSoluong, long nGiaca)
        {
            DonhangID = nDonhangID;
            HanghoaID = nHanghoaID;
            tenhh = nTenhh;
            soluong = nSoluong;
            giaca = nGiaca;
        }
    }
}
