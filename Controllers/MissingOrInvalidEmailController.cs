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
    public class MissingOrInvalidEmailController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MissingOrInvalidEmailController(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        // GET: api/MissingOrInvalidEmail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MissingOrInvalidEmail>>> GetMissingOrInvalidEmails()
        {
            return await _context.MissingOrInvalidEmails.ToListAsync();
        }

        // GET: api/MissingOrInvalidEmail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MissingOrInvalidEmail>> GetMissingOrInvalidEmail(int id)
        {
            var missingOrInvalidEmail = await _context.MissingOrInvalidEmails.FindAsync(id);

            if (missingOrInvalidEmail == null)
            {
                return NotFound();
            }

            return missingOrInvalidEmail;
        }

        // PUT: api/MissingOrInvalidEmail/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMissingOrInvalidEmail(int id, MissingOrInvalidEmail missingOrInvalidEmail)
        {
            if (id != missingOrInvalidEmail.Id)
            {
                return BadRequest();
            }

            _context.Entry(missingOrInvalidEmail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MissingOrInvalidEmailExists(id))
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

        // POST: api/MissingOrInvalidEmail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MissingOrInvalidEmail>> PostMissingOrInvalidEmail(MissingOrInvalidEmail missingOrInvalidEmail)
        {
            _context.MissingOrInvalidEmails.Add(missingOrInvalidEmail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMissingOrInvalidEmail", new { id = missingOrInvalidEmail.Id }, missingOrInvalidEmail);
        }

        // DELETE: api/MissingOrInvalidEmail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMissingOrInvalidEmail(int id)
        {
            var missingOrInvalidEmail = await _context.MissingOrInvalidEmails.FindAsync(id);
            if (missingOrInvalidEmail == null)
            {
                return NotFound();
            }

            _context.MissingOrInvalidEmails.Remove(missingOrInvalidEmail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MissingOrInvalidEmailExists(int id)
        {
            return _context.MissingOrInvalidEmails.Any(e => e.Id == id);
        }
    }
}
