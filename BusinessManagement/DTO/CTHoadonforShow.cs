namespace DTO
{
    public class CTHoadonforShow
    {
        public string HoadonID { get; set; }
        public string DonhangID { get; set; }
        public string ngaylap { get; set; }
        public string ngayxuat { get; set; }
        public string tennv { get; set; }
        public string tenkh { get; set; }
        public long trigia { get; set; }
        public CTHoadonforShow() { }
        public CTHoadonforShow(string nHoadonID, string nDonhangID, string nNgaylap, string nNgayxuat, string nTenNV
            , string nTenKH, long nTrigia)
        {
            HoadonID = nHoadonID;
            DonhangID = nDonhangID;
            ngaylap = nNgaylap;
            ngayxuat = nNgayxuat;
            tennv = nTenNV;
            tenkh = nTenKH;
            trigia = nTrigia;
        }
    }
}
