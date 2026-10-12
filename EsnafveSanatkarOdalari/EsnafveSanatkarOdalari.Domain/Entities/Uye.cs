public class Uye
{
    public int Id { get; set; }
    public required string AdSoyad { get; set; }
    public required string Telefon { get; set; }
    public required string Email { get; set; }
    public required string MeslekGrubu { get; set; }
    public DateTime KayitTarihi { get; set; }
    public bool AktifMi { get; set; }
    public required ICollection<Aidat> Aidatlar { get; set; }
    public required ICollection<Belge> Belgeler { get; set; }
    public required ICollection<Sikayet> Sikayetler { get; set; }
    public required ICollection<EtkinlikKatilim> Etkinlikler { get; set; }
    public required ICollection<Odeme> Odemeler { get; set; }
    public required ICollection<Fatura> Faturalar { get; set; }
    public required ICollection<BankaHesabi> BankaHesaplari { get; set; }
    public required ICollection<Sertifika> Sertifikalar { get; set; }
    public required ICollection<DestekTalebi> DestekTalepleri { get; set; }
    public required ICollection<Basvuru> Basvurular { get; set; }
    public required ICollection<Envanter> Envanterler { get; set; }
    public required ICollection<Sigorta> Sigortalar { get; set; }
}
