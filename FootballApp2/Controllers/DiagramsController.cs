using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement.Mvc;

namespace FootballApp2.Controllers
{
    public class DiagramsController : Controller
    {
        [Authorize]
        [FeatureGate("Diagrams")]
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
