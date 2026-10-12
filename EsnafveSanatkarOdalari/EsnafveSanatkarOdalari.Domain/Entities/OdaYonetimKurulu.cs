public class OdaYonetimKurulu
{
    public int Id { get; set; }
    public int OdaId { get; set; }
    public required string AdSoyad { get; set; }
    public required string Pozisyon { get; set; }
    // Raporlama
    public class Rapor
    {
        public int Id { get; set; }
        public required string Baslik { get; set; }
        public required string RaporTipi { get; set; } // Finansal, Üye, Etkinlik, Şikayet
        public DateTime OlusturmaTarihi { get; set; }
        public required string Olusturan { get; set; }
        public required string Aciklama { get; set; }

        public required ICollection<RaporDetay> Detaylar { get; set; }
    }

    public class RaporDetay
    {
        public int Id { get; set; }
        public int RaporId { get; set; }
        public required string Anahtar { get; set; }
        public required string Deger { get; set; }
        public required Rapor Rapor { get; set; }
    }

    public class FinansalRapor : Rapor
    {
        public decimal ToplamGelir { get; set; }
        public decimal ToplamGider { get; set; }
        public decimal Bakiye { get; set; }
    }

    public class UyeRapor : Rapor
    {
        public int ToplamUye { get; set; }
        public int AktifUyeSayisi { get; set; }
        public int PasifUyeSayisi { get; set; }
        public required Dictionary<string, int> MeslekGruplariDagilimi { get; set; }
    }

    public class EtkinlikRapor : Rapor
    {
        public int ToplamEtkinlik { get; set; }
        public int KatilimciSayisi { get; set; }
        public required string EnPopulerEtkinlik { get; set; }
    }

    public class SikayetRapor : Rapor
    {
        public int ToplamSikayet { get; set; }
        public int CozulenSikayetSayisi { get; set; }
        public int BekleyenSikayetSayisi { get; set; }
    }
}