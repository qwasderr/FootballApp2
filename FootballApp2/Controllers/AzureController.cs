using FootballApp2.Models;
using FootballApp2.Services;
using Microsoft.AspNetCore.Mvc;

namespace FootballApp2.Controllers
{
    public class AzureController : Controller
    {
        private readonly IAzureService _serv_stor;

        public AzureController(IAzureService serv_stor)
        {
            _serv_stor = serv_stor;
        }
        public async Task<IActionResult> Index()
        {
            List<BlobModel>? files = await _serv_stor.ListAsync();
            //return StatusCode(StatusCodes.Status200OK, files);
            return View(files);
        }
    }
}
