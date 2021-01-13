namespace DTO
{
    public class HanghoaLV
    {
        public string HanghoaID { get; set; }
        public string tenhh { get; set; }
        public string nhomhang { get; set; }
        public string dvt { get; set; }
        public string nhacc { get; set; }
        public long giatien { get; set; }
        public HanghoaLV() { }
        public HanghoaLV(string nHanghoaID, string nTenhh, string nNhomhang, string nDvt, string nNhacc, long nGiatien)
        {
            HanghoaID = nHanghoaID;
            tenhh = nTenhh;
            nhomhang = nNhomhang;
            dvt = nDvt;
            nhacc = nNhacc;
            giatien = nGiatien;
        }
    }
}
