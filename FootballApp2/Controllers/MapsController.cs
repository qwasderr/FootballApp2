using FootballApp2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.FeatureManagement.Mvc;

namespace FootballApp2.Controllers
{
    public class MapsController : Controller
    {
        private readonly DbfootballContext _context;

        public MapsController(DbfootballContext context)
        {
            _context = context;
        }
        /*public IActionResult Index()
        {
            Random rnd = new Random();
            int lat, lng;
            var lat_min=50;
            var lng_min=50;
            var lat_max=60;
            var lng_max=60;
            string mark = "{";
            foreach (var el in _context.Countries)
            {
                lat = rnd.Next(lat_min, lat_max);
                lng = rnd.Next(lng_min, lng_max);
                mark += "{";
                mark += string.Format("'name': '{0},", el.Name);
                mark += string.Format("'lat': '{0}',", lat);
                mark += string.Format("'lng': '{0}',", lng);
                mark += string.Format("'rating': '{0}',", el.Rating);
                mark += "},";

            }
            mark += "];";
            ViewBag.Markers = mark;
            return View();
        }*/
        [FeatureGate("Map")]
        public IActionResult Index()
        {
            return View(_context.Countries.ToList());
        }
    }
}
