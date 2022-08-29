using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Domain.Models;
using WebApi.DataAccess;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public OrganizationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Organizations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Organization>>> GetOrganizations()
        {
            return await _context.Organizations
                .Include(x => x.Locations)
                .ThenInclude(x => x.Books)
                .ToListAsync();
        }

        // GET: api/Organizations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Organization>> GetOrganization(Guid id)
        {
            var org = await _context.Organizations.FindAsync(id);

            if (org == null)
            {
                return NotFound();
            }

            return org;
        }

        // PUT: api/Organizations/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrganization(Guid id, Organization org)
        {
            if (id != org.Id)
            {
                return BadRequest();
            }

            _context.Entry(org).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrganizationExists(id))
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

        // POST: api/Organizations
        [HttpPost]
        public async Task<ActionResult<Organization>> PostOrganization(Organization org)
        {
            _context.Organizations.Add(org);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrganization", new { id = org.Id }, org);
        }

        // DELETE: api/Organizations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Organization>> DeleteOrganization(Guid id)
        {
            var org = await _context.Organizations.FindAsync(id);
            if (org == null)
            {
                return NotFound();
            }

            _context.Organizations.Remove(org);
            await _context.SaveChangesAsync();

            return org;
        }

        private bool OrganizationExists(Guid id)
        {
            return _context.Organizations.Any(e => e.Id == id);
        }
    }
}
