namespace DTO
{
    public class Nhanvien
    {
        public string NVID { get; set; }
        public string type { get; set; }
        public string tennv { get; set; }
        public string email { get; set; }
        public string CTChucvuID { get; set; }
        public string CTLamthemID { get; set; }
        public string CTThuongID { get; set; }
        public string CTKyketID { get; set; }
        public string DSKinangID { get; set; }
        public Nhanvien()
        {
        }
        /// <summary>
        /// type=nhanvien || quanly || giamdoc
        /// </summary>
        /// <param name="nNVID"></param>
        /// <param name="nType"></param>
        /// <param name="nTennv"></param>
        /// <param name="nEmail"></param>
        /// <param name="nCTChucvuID"></param>
        /// <param name="nCTLamthemID"></param>
        /// <param name="nCTThuongID"></param>
        /// <param name="nCTKyketID"></param>
        /// <param name="nDSKinangID"></param>
        public Nhanvien(string nNVID, string nType, string nTennv, string nEmail, string nCTChucvuID, string nCTLamthemID,
            string nCTThuongID, string nCTKyketID, string nDSKinangID)
        {
            NVID = nNVID;
            type = nType;
            tennv = nTennv;
            email = nEmail;
            CTChucvuID = nCTChucvuID;
            CTLamthemID = nCTLamthemID;
            CTThuongID = nCTThuongID;
            CTKyketID = nCTKyketID;
            DSKinangID = nDSKinangID;
        }
    }
}
