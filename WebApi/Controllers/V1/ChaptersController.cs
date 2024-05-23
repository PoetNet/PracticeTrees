using Asp.Versioning;
using Domain.Chapters;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.V1;

[ApiVersion("1")]
public class ChaptersController(IChapterQuery _query) : ControllerBase
{
    [HttpGet("tree/{documentId:guid}")]
    public async Task<IActionResult> GetTreeAsync(Guid documentId, CancellationToken cancellationToken)
    {
        return new OkObjectResult(await _query.GetTreeAsync(documentId, cancellationToken));
    }
}
