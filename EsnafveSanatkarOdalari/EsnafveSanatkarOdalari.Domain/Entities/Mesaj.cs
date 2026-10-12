public class Mesaj
{
    public int Id { get; set; }
    public int GonderenId { get; set; }
    public int AliciId { get; set; }
    public required string Icerik { get; set; }
    public DateTime Tarih { get; set; }
}
