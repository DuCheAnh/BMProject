namespace DTO
{
    public class DSKynang
    {
        public string DSKynangID { get; set; }
        public string tenkynang { get; set; }
        public string mucdo { get; set; }
        public string ngaydanhgia { get; set; }
        public DSKynang() { }
        public DSKynang(string nDSKynangID, string nTenkynang, string nMucdo, string nNgaydanhgia)
        {
            DSKynangID = nDSKynangID;
            tenkynang = nTenkynang;
            mucdo = nMucdo;
            ngaydanhgia = nNgaydanhgia;
        }
    }
}
