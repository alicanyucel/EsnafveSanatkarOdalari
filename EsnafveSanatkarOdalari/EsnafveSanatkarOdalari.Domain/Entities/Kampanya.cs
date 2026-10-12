
// Kampanya ve indirimler
public class Kampanya
{
    public int Id { get; set; }
    public required string Baslik { get; set; }
    public required  string Aciklama { get; set; }
    public DateTime BaslangicTarihi { get; set; }
    public DateTime BitisTarihi { get; set; }
    public decimal IndirimOrani { get; set; }
}
