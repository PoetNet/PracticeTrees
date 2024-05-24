using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.PracticeTrees.Configurations;
internal class DocumentConfiguration : IEntityTypeConfiguration<Document>
{

    public void Configure(EntityTypeBuilder<Document> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasMany(x => x.Chapters)
            .WithOne(x => x.Document)
            .HasForeignKey(x => x.DocumentId);
    }
}
