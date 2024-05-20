using Asp.Versioning;
using MassTransit.Mediator;

namespace WebApi.Controllers.V1;

[ApiVersion("1")]
public class ChaptersController : ControllerBase
{
    private readonly IMediator _mediator;

    public ChaptersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    //[HttpGet("{Id}")]
    //public async Task<IActionResult> GetAsync([FromRoute] GetChapter request, CancellationToken cancellationToken)
    //{
    //    return await _mediator.SendRequest(request, cancellationToken);
    //}

    //[HttpGet("tree")]
    //public async Task<IActionResult> GetTreeAsync([FromQuery] GetChapterTree request, CancellationToken cancellationToken)
    //{
    //    return await _mediator.SendRequest(request, cancellationToken);
    //}
}
