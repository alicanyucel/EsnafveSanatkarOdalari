
// Şikayet ve talepler
public class Sikayet
{
    public int Id { get; set; }
    public int UyeId { get; set; }
    public required string Aciklama { get; set; }
    public required string Durum { get; set; }
    public DateTime Tarih { get; set; }
}
