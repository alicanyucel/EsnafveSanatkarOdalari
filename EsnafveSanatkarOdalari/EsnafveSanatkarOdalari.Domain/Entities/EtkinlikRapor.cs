namespace EsnafveSanatkarOdalari.Domain.Entities
{
    public class EtkinlikRapor : Rapor
    {
        public int ToplamEtkinlik { get; set; }
        public int KatilimciSayisi { get; set; }
        public required string EnPopulerEtkinlik { get; set; }
    }
}
