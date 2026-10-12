namespace EsnafveSanatkarOdalari.Domain.Entities
{
    public class SikayetRapor : Rapor
    {
        public int ToplamSikayet { get; set; }
        public int CozulenSikayetSayisi { get; set; }
        public int BekleyenSikayetSayisi { get; set; }
    }
}
