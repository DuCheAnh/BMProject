namespace DTO
{
    public class CTChucVu
    {
        public string CTChucvuID { get; set; }
        public string ChucvuID { get; set; }
        public string NgayUpdate { get; set; }
        public CTChucVu() { }
        public CTChucVu(string nCTChucvuID, string nChucvuID, string nNgayUpdate)
        {
            CTChucvuID = nCTChucvuID;
            ChucvuID = nChucvuID;
            NgayUpdate = nNgayUpdate;
        }
    }
}
