namespace Domain.Entities;
public class Document
{
    public Document(string title, string description)
    {
        Title = title;
        Description = description;

        _chapters = new List<Chapter>();
    }

    public Guid Id { get; }
    public DateTimeOffset CreatedAt { get; private set; }
    public DateTimeOffset? DeletedAt { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }

    private List<Chapter> _chapters;
    public IReadOnlyCollection<Chapter> Chapters => _chapters;
}
