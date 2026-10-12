public class Odeme
{
    public int Id { get; set; }
    public int UyeId { get; set; }
    public decimal Tutar { get; set; }
    public DateTime OdemeTarihi { get; set; }
    public required string OdemeYontemi { get; set; }
}
