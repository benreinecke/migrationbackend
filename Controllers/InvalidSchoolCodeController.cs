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
    public class InvalidSchoolCodeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public InvalidSchoolCodeController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/InvalidSchoolCode
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvalidSchoolCode>>> GetInvalidSchoolCodes()
        {
            return await _context.InvalidSchoolCodes.ToListAsync();
        }

        // GET: api/InvalidSchoolCode/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InvalidSchoolCode>> GetInvalidSchoolCode(int id)
        {
            var invalidSchoolCode = await _context.InvalidSchoolCodes.FindAsync(id);

            if (invalidSchoolCode == null)
            {
                return NotFound();
            }

            return invalidSchoolCode;
        }

        // PUT: api/InvalidSchoolCode/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvalidSchoolCode(int id, InvalidSchoolCode invalidSchoolCode)
        {
            if (id != invalidSchoolCode.RecId)
            {
                return BadRequest();
            }

            _context.Entry(invalidSchoolCode).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvalidSchoolCodeExists(id))
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

        // POST: api/InvalidSchoolCode
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<InvalidSchoolCode>> PostInvalidSchoolCode(InvalidSchoolCode invalidSchoolCode)
        {
            _context.InvalidSchoolCodes.Add(invalidSchoolCode);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (InvalidSchoolCodeExists(invalidSchoolCode.RecId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetInvalidSchoolCode", new { id = invalidSchoolCode.RecId }, invalidSchoolCode);
        }

        // DELETE: api/InvalidSchoolCode/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInvalidSchoolCode(int id)
        {
            var invalidSchoolCode = await _context.InvalidSchoolCodes.FindAsync(id);
            if (invalidSchoolCode == null)
            {
                return NotFound();
            }

            _context.InvalidSchoolCodes.Remove(invalidSchoolCode);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InvalidSchoolCodeExists(int id)
        {
            return _context.InvalidSchoolCodes.Any(e => e.RecId == id);
        }
    }
}
