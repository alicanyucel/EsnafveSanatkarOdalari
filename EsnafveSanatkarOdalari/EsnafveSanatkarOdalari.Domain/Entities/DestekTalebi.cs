public class DestekTalebi
{
    public int Id { get; set; }
    public int UyeId { get; set; }
    public required string Talep { get; set; }
    public required string Durum { get; set; }
    public DateTime Tarih { get; set; }
}
