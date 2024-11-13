using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web_api_nelnet.Data;
using web_api_nelnet.Models;

namespace web_api_nelnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentMissingSalutationController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ParentMissingSalutationController(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        // GET: api/ParentMissingSalutation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ParentMissingSalutation>>> GetParentMissingSalutations()
        {
            return await _context.ParentMissingSalutations.ToListAsync();
        }

        // GET: api/ParentMissingSalutation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ParentMissingSalutation>> GetParentMissingSalutation(int id)
        {
            var parentMissingSalutation = await _context.ParentMissingSalutations.FindAsync(id);

            if (parentMissingSalutation == null)
            {
                return NotFound();
            }

            return parentMissingSalutation;
        }

        // PUT: api/ParentMissingSalutation/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutParentMissingSalutation(int id, ParentMissingSalutation parentMissingSalutation)
        {
            if (id != parentMissingSalutation.Id)
            {
                return BadRequest();
            }

            _context.Entry(parentMissingSalutation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParentMissingSalutationExists(id))
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

        // POST: api/ParentMissingSalutation
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ParentMissingSalutation>> PostParentMissingSalutation(ParentMissingSalutation parentMissingSalutation)
        {
            _context.ParentMissingSalutations.Add(parentMissingSalutation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetParentMissingSalutation", new { id = parentMissingSalutation.Id }, parentMissingSalutation);
        }

        // DELETE: api/ParentMissingSalutation/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteParentMissingSalutation(int id)
        {
            var parentMissingSalutation = await _context.ParentMissingSalutations.FindAsync(id);
            if (parentMissingSalutation == null)
            {
                return NotFound();
            }

            _context.ParentMissingSalutations.Remove(parentMissingSalutation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ParentMissingSalutationExists(int id)
        {
            return _context.ParentMissingSalutations.Any(e => e.Id == id);
        }
    }
}
