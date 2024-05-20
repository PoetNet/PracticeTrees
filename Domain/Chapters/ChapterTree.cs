namespace Domain.Chapters;
public record ChapterTree
{
    public required Guid Id { get; init; }
    public required string Title { get; init; }
    public IEnumerable<ChapterTree>? Children { get; set; }
}
