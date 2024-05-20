namespace Domain.Entities;
public class Asset
{
    protected Asset()
    {

    }

    public Guid Id { get; }
    public Guid ChapterId { get; private set; }
    public Chapter Chapter { get; private set; }
    public DateTimeOffset CreatedAt { get; private set; }
    public DateTimeOffset? DeletedAt { get; private set; }
    public string Name { get; private set; }
    public string FilePath { get; private set; }
    public AssetType Type { get; private set; }
}
