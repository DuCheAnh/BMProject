namespace DTO
{
    public class CTGiaca
    {
        public string CTGiacaID { get; set; }
        public long giaca { get; set; }
        public string NgayUpdate { get; set; }
        public CTGiaca() { }
        public CTGiaca(string nCTGiacaID, long nGiaca, string nNgayUpdate)
        {
            CTGiacaID = nCTGiacaID;
            giaca = nGiaca;
            NgayUpdate = nNgayUpdate;
        }
    }
}
