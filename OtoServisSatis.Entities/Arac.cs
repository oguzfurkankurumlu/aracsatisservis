
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

public class Arac : IEntity
{

    public int Id { get; set; }
    public string MarkaId { get; set; }

    [StringLength(50)] //RENK 50 KARAKTER OLSUN VERİ TABANINDA
    public string Renk { get; set; }
    public decimal Fiyat { get; set; }

    [StringLength(50)] //MODEL 50 KARAKTER OLSUN VERİ TABANINDA
    public string Model { get; set; }

    [StringLength(50)] //KasaTipi 50 KARAKTER OLSUN VERİ TABANINDA
    public string KasaTipi { get; set; }
    public int ModelYili { get; set; }
    public bool SatistaMi { get; set; }
    public string Notlar { get; set; }
    public virtual Marka? Marka { get; set; } //ARAÇ SINIFI İLE MARKA SINIFI ARASINDA BAGLANTI

}