namespace DTO
{
    public class Hanghoa
    {
        public string HanghoaID { get; set; }
        public string tenhh { get; set; }
        public string nhomhang { get; set; }
        public string dvt { get; set; }
        public string NhaccID { get; set; }
        public string CTGiacaID { get; set; }
        public Hanghoa() { }
        public Hanghoa(string nHanghoaID, string nTenhh, string nNhomhang, string nDvt, string nNhaccID, string nCTGiacaID)
        {
            HanghoaID = nHanghoaID;
            tenhh = nTenhh;
            nhomhang = nNhomhang;
            dvt = nDvt;
            NhaccID = nNhaccID;
            CTGiacaID = nCTGiacaID;
        }
    }
}
