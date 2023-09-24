using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FootballApp2.Models;

namespace FootballApp2.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly DbfootballContext _context;

        public CountriesController(DbfootballContext context)
        {
            _context = context;
            //   context.Countries.Add(new Country {Name = "asas", Rating = 111 });
            //   context.SaveChanges();
        }

        // GET: api/Countries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Country>>> GetCountries()
        {
            if (_context.Countries == null)
            {
                return NotFound();
            }
            if (_context.Teams != null)
            {
                foreach (var country in _context.Countries)
                {
                    country.Teams = await _context.Teams.Where(t => t.CountryId == country.Id).ToListAsync();
                }
            }
            return await _context.Countries.ToListAsync();
        }

        // GET: api/Countries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Country>> GetCountry(int id)
        {
            if (_context.Countries == null)
            {
                return NotFound();
            }
            //var country = await _context.Countries.FindAsync(id);
            var country = _context.Countries.Where(c => id == c.Id).FirstOrDefault();
            if (country == null)
            {
                return NotFound();
            }
            if (_context.Teams!=null) country.Teams = _context.Teams.Where(t => t.CountryId == id).ToList();
            return country;
        }

        // PUT: api/Countries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCountry(int id, Country country)
        {
            if (id != country.Id)
            {
                return BadRequest();
            }

            _context.Entry(country).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CountryExists(id))
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

        // POST: api/Countries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Country>> PostCountry(Country country)
        {
            if (_context.Countries == null)
            {
                return Problem("Entity set 'LBAPIContext.Countries'  is null.");
            }
            /*_context.Countries.Add(country);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCountry", new { id = country.Id }, country);*/
            var t = (_context.Countries.Where(a => a.Name == country.Name)).FirstOrDefault();
            if (t == null)
            {
                _context.Countries.Add(country);
                await _context.SaveChangesAsync();
                return CreatedAtAction("GetCountry", new { id = country.Id }, country);
            }
            else return Problem("A country with the same name exists");
        }

        // DELETE: api/Countries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCountry(int id)
        {
            if (_context.Countries == null)
            {
                return NotFound();
            }
            var country = _context.Countries.Where(c => id == c.Id).FirstOrDefault();
            //var country = await _context.Countries.FindAsync(id);
            if (country == null)
            {
                return NotFound();
            }

            _context.Countries.Remove(country);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CountryExists(int id)
        {
            return (_context.Countries?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
