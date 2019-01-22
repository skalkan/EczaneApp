using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EczaneApp.API.Data;
using EczaneApp.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EczaneApp.API.Controllers
{
    // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EczanesController : ControllerBase
    {
        private readonly DataContext _context;

        public EczanesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Eczanes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eczane>>> GetEczanes()
        {
            return await _context.Eczanes.ToListAsync();
        }

        // GET: api/Eczanes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eczane>> GetEczane(int id)
        {
            var eczane = await _context.Eczanes.FindAsync(id);

            if (eczane == null)
            {
                return NotFound();
            }

            return eczane;
        }

        // PUT: api/Eczanes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEczane(int id, Eczane eczane)
        {
            if (id != eczane.Id)
            {
                return BadRequest();
            }

            _context.Entry(eczane).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EczaneExists(id))
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

        // POST: api/Eczanes
        [HttpPost]
        public async Task<ActionResult<Eczane>> PostEczane(Eczane eczane)
        {
            _context.Eczanes.Add(eczane);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEczane", new { id = eczane.Id }, eczane);
        }

        // DELETE: api/Eczanes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Eczane>> DeleteEczane(int id)
        {
            var eczane = await _context.Eczanes.FindAsync(id);
            if (eczane == null)
            {
                return NotFound();
            }

            _context.Eczanes.Remove(eczane);
            await _context.SaveChangesAsync();

            return eczane;
        }

        private bool EczaneExists(int id)
        {
            return _context.Eczanes.Any(e => e.Id == id);
        }
    }
}