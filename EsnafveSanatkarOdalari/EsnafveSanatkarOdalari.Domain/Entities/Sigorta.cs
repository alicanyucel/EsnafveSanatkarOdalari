public class Sigorta
{
    public int Id { get; set; }
    public int UyeId { get; set; }
    public required string SigortaTuru { get; set; }
    public DateTime BaslangicTarihi { get; set; }
    public DateTime BitisTarihi { get; set; }
}
