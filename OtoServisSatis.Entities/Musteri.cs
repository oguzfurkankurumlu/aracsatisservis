
using System.ComponentModel.DataAnnotations;

public class Musteri : IEntity{
    public int Id { get; set; }
    public int AracId { get; set; }
    
    [StringLength (50)]
    public string Ad { get; set; }

    [StringLength (50)]
    public string Soyad { get; set; }

    [StringLength (50)]
    public string Email { get; set; }

    [StringLength (20)]
    public string? Telefon { get; set; }

    [StringLength (500)]
    public string? Adres { get; set; }

    [StringLength (11)]
    public string? TcNo { get; set; }
    public string? Notlar { get; set; }
    public virtual Arac? Arac { get; set; }

}