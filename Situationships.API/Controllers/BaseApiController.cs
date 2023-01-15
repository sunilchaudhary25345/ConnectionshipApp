using Microsoft.AspNetCore.Mvc;
using Situationships.API.Helpers;

namespace Situationships.API.Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController: ControllerBase
    {
        
    }
}