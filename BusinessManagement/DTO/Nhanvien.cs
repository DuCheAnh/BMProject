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
        public string ngaysinh { get; set; }
        public string gioitinh { get; set; }
        public string noisinh { get; set; }
        public string diachi { get; set; }
        public string trinhdo { get; set; }
        public string PBID { get; set; }
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
        public Nhanvien(string nNVID, string nType, string nTennv, string nEmail, string nNgaysinh, string nGioitinh,
            string nNoisinh, string nDiachi, string nTrinhdo,string nPBID, string nCTChucvuID, string nCTLamthemID, string nCTThuongID, string nCTKyketID, string nDSKinangID)
        {
            NVID = nNVID;
            type = nType;
            tennv = nTennv;
            email = nEmail;
            ngaysinh = nNgaysinh;
            gioitinh = nGioitinh;
            noisinh = nNoisinh;
            diachi = nDiachi;
            trinhdo = nTrinhdo;
            PBID = nPBID;
            CTChucvuID = nCTChucvuID;
            CTLamthemID = nCTLamthemID;
            CTThuongID = nCTThuongID;
            CTKyketID = nCTKyketID;
            DSKinangID = nDSKinangID;
        }
    }
}
