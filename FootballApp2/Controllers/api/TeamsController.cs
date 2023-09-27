using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FootballApp2.Models;
using FootballApp2.Services;
using System.Transactions;
using Nest;

namespace FootballApp2.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly DbfootballContext _context;

        public TeamsController(DbfootballContext context)
        {
            _context = context;
        }

        // GET: api/Teams
        //[HttpGet("{skip}/{limit}")]

        [HttpGet("params")]
        public async Task<ActionResult<PaginationTeam>> GetTeams([FromQuery] int skip, [FromQuery] int limit)
        {
            if (_context.Teams == null)
            {
                return NotFound();
            }
            //_context.Teams.OrderBy(on => on.Name).Skip((config.PageNumber - 1) * config.PageSize).Take(config.PageSize).ToList();
            //return await _context.Teams.ToListAsync();
            foreach (var team in _context.Teams) { team.Country=_context.Countries.Where(t=>t.Id==team.CountryId).FirstOrDefault(); }
            var res= await _context.Teams.OrderBy(on => on.Name).Skip(skip*limit).Take(limit).ToListAsync();
            PaginationTeam pag=new PaginationTeam();
            pag.limit=limit;
            pag.skip=skip;
            double a = _context.Teams.Count() / (double)limit;
            pag.total = (int)Math.Ceiling(a);
            pag.team = res;
            pag.nextLink = skip+1<pag.total ? $"/api/Teams/?skip={skip+1}&limit={limit}" : null;
            return pag;
        }

        // GET: api/Teams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Team>> GetTeam(int id)
        {
            if (_context.Teams == null)
            {
                return NotFound();
            }
            var team = await _context.Teams.FindAsync(id);

            if (team == null)
            {
                return NotFound();
            }

            return team;
        }

        // PUT: api/Teams/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeam(int id, Team team)
        {
            if (id != team.Id)
            {
                return BadRequest();
            }

            _context.Entry(team).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Teams
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Team>> PostTeam(Team team)
        {
            if (_context.Teams == null)
            {
                return Problem("Entity set 'LBAPIContext.Teams'  is null.");
            }
            _context.Teams.Add(team);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTeam", new { id = team.Id }, team);
        }

        // DELETE: api/Teams/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeam(int id)
        {
            if (_context.Teams == null)
            {
                return NotFound();
            }
            var team = await _context.Teams.FindAsync(id);
            if (team == null)
            {
                return NotFound();
            }

            _context.Teams.Remove(team);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TeamExists(int id)
        {
            return (_context.Teams?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
