namespace DTO
{
    public class CTLamthem
    {
        public string CTLamthemID { get; set; }
        public string tennv { get; set; }
        public float sogiolamthem { get; set; }
        public int thang { get; set; }
        public CTLamthem() { }
        public CTLamthem(string nCTLamthemID, float nSogiolamthem, int nThang)
        {
            CTLamthemID = nCTLamthemID;
            sogiolamthem = nSogiolamthem;
            thang = nThang;
        }
    }
}
