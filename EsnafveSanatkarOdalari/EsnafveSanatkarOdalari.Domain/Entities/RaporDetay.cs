namespace EsnafveSanatkarOdalari.Domain.Entities
{
    public class RaporDetay
    {
        public int Id { get; set; }
        public int RaporId { get; set; }
        public required string Anahtar { get; set; }
        public required string Deger { get; set; }
        public required Rapor Rapor { get; set; }
    }
}
