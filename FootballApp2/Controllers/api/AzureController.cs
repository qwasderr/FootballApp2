using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FootballApp2.Models;
using FootballApp2.Services;

namespace FootballApp2.Controllers.api
{
    [Route("api/Azure")]
    [ApiController]
    public class AzureController : ControllerBase
    {
        private readonly IAzureService _serv_stor;

        public AzureController(IAzureService serv_stor)
        {
            _serv_stor = serv_stor;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<BlobModel>? files = await _serv_stor.ListAsync();
            return StatusCode(StatusCodes.Status200OK, files);
        }
    }
}
