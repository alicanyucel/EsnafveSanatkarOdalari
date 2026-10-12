public class Fatura
{
    public int Id { get; set; }
    public int UyeId { get; set; }
    public required string FaturaNo { get; set; }
    public DateTime Tarih { get; set; }
    public decimal Tutar { get; set; }
}
