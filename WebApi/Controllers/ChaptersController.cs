﻿using Asp.Versioning;
using Database.PracticeTrees;
using Domain.Chapters;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiVersion("1")]
[Route("api/")]
public class ChaptersController(IChapterQuery _query, DocumentationDbContext _context) : ControllerBase
{
    [HttpGet("tree/{documentId:guid}")]
    public async Task<IActionResult> GetTreeAsync(Guid documentId, CancellationToken cancellationToken)
    {
        return new OkObjectResult(await _query.GetTreeAsync(documentId, cancellationToken));
    }
}