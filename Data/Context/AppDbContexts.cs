using Microsoft.EntityFrameworkCore;
using TestMigrations.Data.Entiteies;

namespace TestMigrations.Data.Context;

public class AppDbContexts:DbContext
{
    public DbSet<Teachers> Teachers { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-ET5TVFM\SQLEXPRESS;
        Initial Catalog=testMigration;
        Integrated Security=True;
        TrustServerCertificate=True;");
    }
}
