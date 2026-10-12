public class Sertifika
{
    public int Id { get; set; }
    public int UyeId { get; set; }
    public required string SertifikaAdi { get; set; }
    public DateTime VerilisTarihi { get; set; }
    public DateTime? GecerlilikTarihi { get; set; }
}
