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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }

    // for Sqlite:
    //protected override void OnConfiguring(DbContextOptionsBuilder options)
    //{
    //    options.UseSqlite(@"Data Source=..\DocumentDb.db",
    //        b => b.MigrationsAssembly("Database.PracticeTrees.Migrations"));
    //}    

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var env = Environment.GetEnvironmentVariables();
        string connection =
        $"""
            Host={env["DB_HOST"]};
            Port={env["DB_PORT"]};
            Database={env["DB_DATABASE"]};
            Username={env["DB_USERNAME"]};
            Password={env["DB_PASSWORD"]};
        """;

        options.UseNpgsql(connection);
    }
}
