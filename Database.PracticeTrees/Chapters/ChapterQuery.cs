using Domain.Chapters;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace Database.PracticeTrees.Chapters;

public class ChapterQuery : IChapterQuery
{
    private readonly DocumentationDbContext _context;

    public ChapterQuery(DocumentationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ChapterTree>> GetTreeByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var data = await _context.Chapters
            .Where(x => x.ParentId == id || x.Id == id)
            .Select(x => new ChapterDto()
            {
                Id = x.Id,
                Title = x.Title,
                ParentId = x.ParentId,
                Order = x.Order
            })
            .OrderBy(x => x.Order)
            .ToListAsync(cancellationToken);

        var lookUp = data.ToLookup(x => x.ParentId, x => new ChapterTree()
        {
            Id = x.Id,
            Title = x.Title
        });

        foreach (var node in lookUp.SelectMany(x => x))
        {
            node.Children = lookUp
                .Where(x => x.Key == node.Id)
                .SelectMany(x => x)
                .ToList();
        }

        var rootNodes = lookUp
            .Where(x => x.Key == null)
            .SelectMany(x => x)
            .ToList();

        return rootNodes;
    }

    public async Task<IEnumerable<ChapterTree>> GetTreeAsync(Guid documentId, CancellationToken cancellationToken)
    {
        var data = await _context.Chapters
            .Where(x => x.DocumentId == documentId)
            .Select(x => new ChapterDto()
            {
                Id = x.Id,
                Title = x.Title,
                ParentId = x.ParentId,
                Order = x.Order
            })
            .OrderBy(x => x.Order)
            .ToListAsync(cancellationToken);

        var lookUp = data.ToLookup(x => x.ParentId, x => new ChapterTree()
        {
            Id = x.Id,
            Title = x.Title
        });

        foreach (var node in lookUp.SelectMany(x => x))
        {
            node.Children = lookUp
                .Where(x => x.Key == node.Id)
                .SelectMany(x => x)
                .ToList();
        }

        var rootNodes = lookUp
            .Where(x => x.Key == null)
            .SelectMany(x => x)
            .ToList();

        return rootNodes;
    }

    public async Task<Chapter?> GetChapterWithChildrenAsync(Guid chapterId, CancellationToken cancellationToken)
    {
        var chapter = await _context.Chapters
            //.Include(x => x.Children)
            .FirstOrDefaultAsync(x => x.Id == chapterId, cancellationToken);

        if (chapter == null)
        {
            return chapter;
        }

        await _context.Entry(chapter)
            .Collection(c => c.Children)
            .Query()
            .Include(c => EF.Property<IReadOnlyCollection<Chapter>>(c, "Children"))
            .LoadAsync(cancellationToken);


        return chapter;
    }

    public async Task<List<Chapter>> GetChapterWithChildrenAsync(Guid chapterId)
    {
        var chapters = await _context.Chapters
            .FromSqlInterpolated($"SELECT * FROM (WITH ChapterCTE AS (SELECT * FROM Chapters WHERE Id = {chapterId} UNION ALL SELECT * FROM Chapters c JOIN ChapterCTE cte ON c.ParentId = cte.Id) SELECT * FROM ChapterCTE) AS Result")
            .ToListAsync();

        return chapters;
    }
}
