dotnet add package Microsoft.EntityFrameworkCore --version 9.0.0
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 9.0.0
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 9.0.0

Entityleri olusturdakn sonra databasecontext e girip bu paketleri kurdum.

public class DatabaseContext : DbContext{}
olusturup ıcıne db leri tanımladım.

data kısmında dbset yapıp fluentapi kısmını verdim
