namespace DTO
{
    public class Nhacc
    {
        public string NhaccID { get; set; }
        public string tennhacc { get; set; }
        public string sdt { get; set; }
        public Nhacc() { }
        public Nhacc(string nNhaccID, string nTennhacc, string nSdt)
        {
            NhaccID = nNhaccID;
            tennhacc = nTennhacc;
            sdt = nSdt;
        }
    }
}
