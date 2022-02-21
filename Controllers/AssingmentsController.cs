#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MagnifinanceUniversity.Data;
using MagnifinanceUniversity.Models;

namespace MagnifinanceUniversity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssingmentsController : ControllerBase
    {
        private readonly SchoolContext _context;

        public AssingmentsController(SchoolContext context)
        {
            _context = context;
        }

        // GET: api/Assingments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Assingment>>> GetAssingments()
        {
            return await _context.Assingments.ToListAsync();
        }

        // GET: api/Assingments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Assingment>> GetAssingment(int id)
        {
            var assingment = await _context.Assingments.FindAsync(id);

            if (assingment == null)
            {
                return NotFound();
            }

            return assingment;
        }

        // PUT: api/Assingments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAssingment(int id, Assingment assingment)
        {
            if (id != assingment.AssingmentID)
            {
                return BadRequest();
            }

            _context.Entry(assingment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssingmentExists(id))
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

        // POST: api/Assingments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Assingment>> PostAssingment(Assingment assingment)
        {
            _context.Assingments.Add(assingment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAssingment", new { id = assingment.AssingmentID }, assingment);
        }

        // DELETE: api/Assingments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAssingment(int id)
        {
            var assingment = await _context.Assingments.FindAsync(id);
            if (assingment == null)
            {
                return NotFound();
            }

            _context.Assingments.Remove(assingment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AssingmentExists(int id)
        {
            return _context.Assingments.Any(e => e.AssingmentID == id);
        }
    }
}
