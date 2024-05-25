namespace Domain.Chapters;
public interface IChapterQuery
{
    Task<IEnumerable<ChapterTree>> GetTreeByIdAsync(Guid id, CancellationToken cancellationToken);
    Task<IEnumerable<ChapterTree>> GetTreeAsync(Guid documentId, CancellationToken cancellationToken);
}
