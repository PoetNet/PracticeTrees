namespace Domain.Chapters;
public record ChapterDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public Guid? ParentId { get; set; }
    public int Order { get; set; }
}
