namespace Domain.Entities;
public class Chapter
{
    public Chapter(string title, string body, string css)
    {
        Title = title;
        Body = body;
        Css = css;

        _assets = new List<Asset>();
        _chapters = new List<Chapter>();
    }

    public Guid Id { get; }

    public string Title { get; private set; }
    public string Body { get; private set; }
    public string Css { get; private set; }
    public int Order { get; private set; }
    public DateTimeOffset CreatedAt { get; private set; }
    public DateTimeOffset? DeletedAt { get; private set; }

    public Guid? ParentId { get; private set; }
    public Chapter? Parent { get; private set; }

    private List<Chapter> _chapters;
    public IReadOnlyCollection<Chapter> Children => _chapters;

    public Guid DocumentId { get; private set; }
    public Document Document { get; private set; }

    private List<Asset> _assets;
    public IReadOnlyCollection<Asset> Assets => _assets;
}
