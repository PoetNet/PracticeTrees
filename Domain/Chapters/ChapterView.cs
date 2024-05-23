namespace Domain.Chapters;
public record ChapterView
{
    public required Guid Id { get; init; }
    public required string Title { get; init; }
    public required string Body { get; init; }
    public required string Css { get; init; }
    public required IEnumerable<Asset> Assets { get; init; }

    public record Asset
    {
        public required string Name { get; init; }
        public required string FilePath { get; init; }
        public required string Type { get; init; }
    }
}
