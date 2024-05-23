namespace Domain.Chapters;
public interface IChapterQuery
{
    //Task<ChapterView?> GetAsync(Guid Id, CancellationToken cancellationToken);
    Task<IEnumerable<ChapterTree>> GetTreeAsync(Guid documentId, CancellationToken cancellationToken);
}
