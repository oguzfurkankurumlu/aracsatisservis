
public class Musteri : IEntity{
    public int Id { get; set; }
    public int AracId { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Email { get; set; }
    public string Telefon { get; set; }
    public string Adres { get; set; }
    public string TcNo { get; set; }
    public string Notlar { get; set; }
    public virtual Arac Arac { get; set; }

}