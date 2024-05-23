using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database.PracticeTrees;
public class DocumentationDbContext : DbContext
{
    public DocumentationDbContext(DbContextOptions<DocumentationDbContext> options) : base(options)
    { }

    public DbSet<Asset> Assets => Set<Asset>();
    public DbSet<Chapter> Chapters => Set<Chapter>();
    public DbSet<Document> Documents => Set<Document>();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite(@"Data Source=..\DocumentDb.db",
            b => b.MigrationsAssembly("Database.PracticeTrees.Migrations"));
    }
}
