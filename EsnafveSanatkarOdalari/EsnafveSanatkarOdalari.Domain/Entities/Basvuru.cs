public class Basvuru
{
    public int Id { get; set; }
    public int IsIlaniId { get; set; }
    public int UyeId { get; set; }
    public DateTime BasvuruTarihi { get; set; }
    public required string Durum { get; set; }
}
