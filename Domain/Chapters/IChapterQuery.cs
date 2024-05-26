using Domain.Entities;

namespace Domain.Chapters;
public interface IChapterQuery
{
    Task<IEnumerable<ChapterTree>> GetTreeByIdAsync(Guid id, CancellationToken cancellationToken);
    Task<IEnumerable<ChapterTree>> GetTreeAsync(Guid documentId, CancellationToken cancellationToken);
    Task<Chapter?> GetChapterWithChildrenAsync(Guid chapterId, CancellationToken cancellationToken);
    Task<List<Chapter>> GetChapterWithChildrenAsync(Guid chapterId);
}
