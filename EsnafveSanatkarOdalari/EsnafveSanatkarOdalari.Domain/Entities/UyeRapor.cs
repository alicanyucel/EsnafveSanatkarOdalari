namespace EsnafveSanatkarOdalari.Domain.Entities
{
    public class UyeRapor : Rapor
    {
        public int ToplamUye { get; set; }
        public int AktifUyeSayisi { get; set; }
        public int PasifUyeSayisi { get; set; }
        public required Dictionary<string, int> MeslekGruplariDagilimi { get; set; }
    }
}
