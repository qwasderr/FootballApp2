using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement.Mvc;

namespace FootballApp2.Controllers
{
    public class CatController : Controller
    {
        [FeatureGate("Cat")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
