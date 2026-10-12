namespace EsnafveSanatkarOdalari.Domain.Entities
{
    public class Rapor
    {
        public int Id { get; set; }
        public required string Baslik { get; set; }
        public required string RaporTipi { get; set; } // Finansal, Üye, Etkinlik, Şikayet
        public  DateTime OlusturmaTarihi { get; set; }
        public required string Olusturan { get; set; }
        public required string Aciklama { get; set; }

        public required ICollection<RaporDetay> Detaylar { get; set; }
    }
}
