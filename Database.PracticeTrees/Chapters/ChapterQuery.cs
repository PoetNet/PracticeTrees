﻿using Domain.Chapters;
using Microsoft.EntityFrameworkCore;

namespace Database.PracticeTrees.Chapters;

public class ChapterQuery(DocumentationDbContext _context) : IChapterQuery
{
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
}