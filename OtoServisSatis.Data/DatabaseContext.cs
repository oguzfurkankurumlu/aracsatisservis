
using Microsoft.EntityFrameworkCore;

public class DatabaseContext : DbContext
{
    // DatabaseContext, EF Core'un sağladığı DbContext sınıfından türetilmiştir.
    // DbContext, Entity Framework'ün veritabanı işlemlerini (CRUD: Create, Read, Update, Delete) 
    // gerçekleştirdiği merkezi bir sınıftır.
    // Bu sınıf, veritabanındaki tabloları temsil eden DbSet koleksiyonlarını içerir 
    // ve bağlantı ayarlarını barındırır.

    public DbSet<Arac>? Araclar { get; set; }
    public DbSet<Kullanici>? Kullanicilar { get; set; }
    public DbSet<Marka>? Markalar { get; set; }
    public DbSet<Rol>? Roller { get; set; }
    public DbSet<Satis>? Satislar { get; set; }
    public DbSet<Musteri>? Musteriler { get; set; }
    public DbSet<Servis>? Servisler { get; set; }


    // DbSet, bir veritabanı tablosunu temsil eder. Her bir DbSet için ilgili sınıf belirtilmiştir. Örneğin:
    // Araclar, veritabanındaki Arac tablosunu temsil eder.
    // Kullanicilar, veritabanındaki Kullanici tablosunu temsil eder.
    // Bu yapı sayesinde, EF Core üzerinden doğrudan ilgili tablodaki verilere erişilebilir 
    // ve işlemler yapılabilir.
    // Not: Arac, Kullanici, Marka gibi sınıflar, genellikle model sınıfları olarak tanımlanır
    //ve veritabanı tablolarındaki sütunları temsil eden özelliklere sahiptir.



    // OnConfiguring metodu, veritabanı bağlantı ayarlarını tanımlar.
    // Burada DbContextOptionsBuilder kullanılarak EF Core'un 
    // hangi veritabanına bağlanacağı ve hangi bağlantı dizesini (connection string) kullanacağı belirtilir.
    // Connection String Açıklaması:
    // Server=.; → Veritabanı sunucusu belirtilir. . ifadesi, yerel (localhost) bir SQL Server'ı temsil eder.
    // Database=OtoServisSatis; → Bağlanılacak veritabanının adı OtoServisSatis.
    // Trusted_Connection=True; → Windows kimlik doğrulaması ile bağlantı yapılacağını belirtir.
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=OtoServisSatis;Trusted_Connection=True; Security=true");
        base.OnConfiguring(optionsBuilder);
    }
    //bu kod bir Entity Framework Core (EF Core) yapılandırmasıdır ve 
    //veritabanı işlemleri için bir DbContext sınıfı tanımlamaktadır. 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // FLUENT API
        modelBuilder.Entity<Rol>().HasData(new Rol
        {   Id = 1, 
            Ad = "Admin"
        });
        modelBuilder.Entity<Kullanici>().HasData(new Kullanici
        {
            Id = 1,
            Ad = "Admin",
            Soyad = "Admin",
            Telefon = "0850",
            AktifMi = true,
            EklenmeTarihi = DateTime.Now,
            Email= "admin@otoservisaracsatis.tc",
            KullaniciAdi = "admin",
            Sifre ="123456",
            RolId = 1,
            Rol = new Rol {
                Id= 1,
                Ad = "Admin"
            }
        });
        base.OnModelCreating(modelBuilder);
    }




}
