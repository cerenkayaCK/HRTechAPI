using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HRTechAPI;
using HRTechAPI.Entities;

namespace HRTechAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonellerController : ControllerBase
    {
        private readonly UygulamaDbContext _context;

        public PersonellerController(UygulamaDbContext context)
        {
            _context = context;
        }

        // GET: api/Personeller
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Personel>>> GetPersoneller()
        {
            return await _context.Personeller.ToListAsync();
        }

        // GET: api/Personeller/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Personel>> GetPersonel(int id)
        {
            var personel = await _context.Personeller.FindAsync(id);

            if (personel == null)
            {
                return NotFound();
            }

            return personel;
        }

        // PUT: api/Personeller/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonel(int id, Personel personel)
        {
            if (id != personel.Id)
            {
                return BadRequest();
            }

            _context.Entry(personel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonelExists(id))
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

        // POST: api/Personeller
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Personel>> PostPersonel(Personel personel)
        {
            _context.Personeller.Add(personel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPersonel", new { id = personel.Id }, personel);
        }

        // DELETE: api/Personeller/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonel(int id)
        {
            var personel = await _context.Personeller.FindAsync(id);
            if (personel == null)
            {
                return NotFound();
            }

            _context.Personeller.Remove(personel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PersonelExists(int id)
        {
            return _context.Personeller.Any(e => e.Id == id);
        }
    }
}
