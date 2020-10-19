using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TP_AccessData;
using TP_Domain.Entities;

namespace TP_Template_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnalisisController : ControllerBase
    {
        private readonly TemplateDbContext _context;

        public AnalisisController(TemplateDbContext context)
        {
            _context = context;
        }

        // GET: api/Analisis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Analisis>>> GetAnalisisList()
        {
            return await _context.AnalisisList.ToListAsync();
        }

        // GET: api/Analisis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Analisis>> GetAnalisis(int id)
        {
            var analisis = await _context.AnalisisList.FindAsync(id);

            if (analisis == null)
            {
                return NotFound();
            }

            return analisis;
        }

        // PUT: api/Analisis/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnalisis(int id, Analisis analisis)
        {
            if (id != analisis.AnalisisId)
            {
                return BadRequest();
            }

            _context.Entry(analisis).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnalisisExists(id))
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

        // POST: api/Analisis
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Analisis>> PostAnalisis(Analisis analisis)
        {
            _context.AnalisisList.Add(analisis);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAnalisis", new { id = analisis.AnalisisId }, analisis);
        }

        // DELETE: api/Analisis/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Analisis>> DeleteAnalisis(int id)
        {
            var analisis = await _context.AnalisisList.FindAsync(id);
            if (analisis == null)
            {
                return NotFound();
            }

            _context.AnalisisList.Remove(analisis);
            await _context.SaveChangesAsync();

            return analisis;
        }

        private bool AnalisisExists(int id)
        {
            return _context.AnalisisList.Any(e => e.AnalisisId == id);
        }
    }
}
