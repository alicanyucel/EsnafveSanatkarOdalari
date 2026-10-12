
// Belgeler ve sertifikalar
public class Belge
{
    public int Id { get; set; }
    public int UyeId { get; set; }
    public required string BelgeAdi { get; set; }
    public DateTime VerilisTarihi { get; set; }
    public DateTime? SonGecerlilikTarihi { get; set; }
}
