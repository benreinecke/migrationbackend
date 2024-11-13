using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web_api_nelnet.Data;
using web_api_nelnet.Models;
using System.Text.RegularExpressions;

namespace web_api_nelnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvalidPhoneNumberController : ControllerBase
    {
        private readonly AppDbContext _context;

        public InvalidPhoneNumberController(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        // GET: api/InvalidPhoneNumber
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvalidPhoneNumber>>> GetInvalidPhoneNumbers()
        {
            return await _context.InvalidPhoneNumbers.ToListAsync();
        }

        // GET: api/InvalidPhoneNumber/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InvalidPhoneNumber>> GetInvalidPhoneNumber(int id)
        {
            var invalidPhoneNumber = await _context.InvalidPhoneNumbers.FindAsync(id);

            if (invalidPhoneNumber == null)
            {
                return NotFound();
            }

            return invalidPhoneNumber;
        }

        // PUT: api/InvalidPhoneNumber/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvalidPhoneNumber(int id, InvalidPhoneNumber invalidPhoneNumber)
        {
            if (id != invalidPhoneNumber.Id)
            {
                return BadRequest();
            }

            _context.Entry(invalidPhoneNumber).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvalidPhoneNumberExists(id))
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

        // POST: api/InvalidPhoneNumber
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<InvalidPhoneNumber>> PostInvalidPhoneNumber(InvalidPhoneNumber invalidPhoneNumber)
        {
            _context.InvalidPhoneNumbers.Add(invalidPhoneNumber);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInvalidPhoneNumber", new { id = invalidPhoneNumber.Id }, invalidPhoneNumber);
        }

        // DELETE: api/InvalidPhoneNumber/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInvalidPhoneNumber(int id)
        {
            var invalidPhoneNumber = await _context.InvalidPhoneNumbers.FindAsync(id);
            if (invalidPhoneNumber == null)
            {
                return NotFound();
            }

            _context.InvalidPhoneNumbers.Remove(invalidPhoneNumber);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InvalidPhoneNumberExists(int id)
        {
            return _context.InvalidPhoneNumbers.Any(e => e.Id == id);
        }
    }
}
