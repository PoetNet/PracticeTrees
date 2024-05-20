using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

/// <summary>
/// BaseController with versioning
/// </summary>
[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
public class ControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
{
}
