using Microsoft.AspNetCore.Identity;

namespace EsnafveSanatkarOdalari.Domain.Entities
{
    public sealed class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName => string.Join(" ", FirstName, LastName);
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpires { get; set; }
    }
}
// Üye ve ilişkili varlıklar
public class Uye
{
    public int Id { get; set; }
    public string AdSoyad { get; set; }
    public string TcKimlikNo { get; set; }
    public string Telefon { get; set; }
    public string Email { get; set; }
    public string MeslekGrubu { get; set; }
    public DateTime KayitTarihi { get; set; }
    public bool AktifMi { get; set; }

    public ICollection<Aidat> Aidatlar { get; set; }
    public ICollection<Belge> Belgeler { get; set; }
    public ICollection<Sikayet> Sikayetler { get; set; }
    public ICollection<EtkinlikKatilim> Etkinlikler { get; set; }
    public ICollection<Odeme> Odemeler { get; set; }
    public ICollection<Fatura> Faturalar { get; set; }
    public ICollection<BankaHesabi> BankaHesaplari { get; set; }
    public ICollection<Sertifika> Sertifikalar { get; set; }
    public ICollection<DestekTalebi> DestekTalepleri { get; set; }
    public ICollection<Basvuru> Basvurular { get; set; }
    public ICollection<Envanter> Envanterler { get; set; }
    public ICollection<Sigorta> Sigortalar { get; set; }
}

// Finans ve ödeme
public class Aidat { /* ... */ }
public class Odeme { /* ... */ }
public class Fatura { /* ... */ }
public class BankaHesabi { /* ... */ }

// Belgeler ve sertifikalar
public class Belge { /* ... */ }
public class Sertifika { /* ... */ }
public class Sigorta { /* ... */ }

// İletişim ve duyuru
public class Duyuru { /* ... */ }
public class Mesaj { /* ... */ }
public class LogKaydi { /* ... */ }

// Etkinlik ve toplantılar
public class Etkinlik { /* ... */ }
public class EtkinlikKatilim { /* ... */ }
public class Toplanti { /* ... */ }
public class Egitim { /* ... */ }

// Şikayet ve talepler
public class Sikayet { /* ... */ }
public class DestekTalebi { /* ... */ }

// Kampanya ve indirimler
public class Kampanya { /* ... */ }

// İş ilanları ve başvurular
public class IsIlani { /* ... */ }
public class Basvuru { /* ... */ }

// Envanter ve ürünler
public class Envanter { /* ... */ }

// Oda yönetimi
public class Oda { /* ... */ }
public class OdaPersonel { /* ... */ }
public class OdaYonetimKurulu { /* ... */ }

// Raporlama
public class Rapor
{
    public int Id { get; set; }
    public string Baslik { get; set; }
    public string RaporTipi { get; set; } // Finansal, Üye, Etkinlik, Şikayet
    public DateTime OlusturmaTarihi { get; set; }
    public string Olusturan { get; set; }
    public string Aciklama { get; set; }

    public ICollection<RaporDetay> Detaylar { get; set; }
}

public class RaporDetay
{
    public int Id { get; set; }
    public int RaporId { get; set; }
    public string Anahtar { get; set; }
    public string Deger { get; set; }
    public Rapor Rapor { get; set; }
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
    public Dictionary<string, int> MeslekGruplariDagilimi { get; set; }
}

public class EtkinlikRapor : Rapor
{
    public int ToplamEtkinlik { get; set; }
    public int KatilimciSayisi { get; set; }
    public string EnPopulerEtkinlik { get; set; }
}

public class SikayetRapor : Rapor
{
    public int ToplamSikayet { get; set; }
    public int CozulenSikayetSayisi { get; set; }
    public int BekleyenSikayetSayisi { get; set; }
}