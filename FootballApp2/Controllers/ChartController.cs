using FootballApp2.Models;
using Microsoft.AspNetCore.Mvc;

namespace FootballApp2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartController : ControllerBase
    {
        private readonly DbfootballContext _context;
        public ChartController(DbfootballContext context)
        {
            _context = context;
        }
        [HttpGet("JsonData")]
        public JsonResult JsonData()
        {
            var teams = _context.Countries.ToList();
            List<object> list = new List<object>();
            list.Add(new[] { "Країна", "Кількість команд" });
            foreach (var i in teams)
            {
                var count=_context.Teams.Where(d=>d.CountryId==i.Id).Count();
                list.Add(new object[] { i.Name, count });
            }
            return new JsonResult(list);
        }
        /*[HttpGet("JsonData2")]
        public JsonResult JsonData2()
        {
            var gs = _context.Authors.ToList();
            List<object> list = new List<object>();
            list.Add(new[] { "Автор", "Кількість книжок" });
            foreach (var i in gs)
            {
                var temp = from d in _context.AuthorsBooks.Where(d => d.AuthorId == i.AuthorId) select d;

                list.Add(new object[] { i.AuthorName, temp.Count() });
            }
            return new JsonResult(list);
        }*/
    }
}
