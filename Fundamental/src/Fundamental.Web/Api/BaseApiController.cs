using Microsoft.AspNetCore.Mvc;

namespace Fundamental.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : Controller
    {
    }
}
