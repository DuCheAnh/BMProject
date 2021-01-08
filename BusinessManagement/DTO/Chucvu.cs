namespace DTO
{
    public class Chucvu
    {
        public string ChucvuID { get; set; }
        public string tenchucvu { get; set; }
        public long thuongchucvu { get; set; }
        public Chucvu() { }
        public Chucvu(string nChucvuID, string nTenchucvu, long nThuongchucvu)
        {
            ChucvuID = nChucvuID;
            tenchucvu = nTenchucvu;
            thuongchucvu = nThuongchucvu;
        }
    }
}
