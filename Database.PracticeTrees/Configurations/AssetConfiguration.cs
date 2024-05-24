using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.PracticeTrees.Configurations;
internal class AssetConfiguration : IEntityTypeConfiguration<Asset>
{
    public void Configure(EntityTypeBuilder<Asset> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Chapter)
            .WithMany(x => x.Assets)
            .HasForeignKey(x => x.ChapterId);
    }
}
