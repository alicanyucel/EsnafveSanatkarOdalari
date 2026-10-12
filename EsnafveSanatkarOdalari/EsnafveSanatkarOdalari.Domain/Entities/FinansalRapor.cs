namespace EsnafveSanatkarOdalari.Domain.Entities
{
    public class FinansalRapor : Rapor
    {
        public decimal ToplamGelir { get; set; }
        public decimal ToplamGider { get; set; }
        public decimal Bakiye { get; set; }
    }
}
