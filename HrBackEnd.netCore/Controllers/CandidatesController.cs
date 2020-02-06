using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HrBackEnd.netCore.Entitys;
using HrBackEnd.netCore.Repository;

namespace HrBackEnd.netCore.Controllers
{



    [Route("[controller]")]
    [ApiController]
    public class CandidatesController : ControllerBase
    {
        private readonly HRDBContext_12 _context;

        public CandidatesController(HRDBContext_12 context)
        {
            _context = context;
        }

        // GET: api/Candidates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Candidate>>> Getcandidates()
        {
            return await _context.candidates.ToListAsync();
        }

        // GET: api/Candidates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Candidate>> GetCandidate(int id)
        {
            var candidate = await _context.candidates.FindAsync(id);

            if (candidate == null)
            {
                return NotFound();
            }

            return candidate;
        }

        // PUT: api/Candidates/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCandidate(int id, Candidate candidate)
        {
            if (id != candidate.idCandidate)
            {
                return BadRequest();
            }

            _context.Entry(candidate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CandidateExists(id))
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

        // POST: api/Candidates
        [HttpPost]
        public async Task<ActionResult<Candidate>> PostCandidate(Candidate candidate)
        {
            _context.candidates.Add(candidate);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCandidate", new { id = candidate.idCandidate }, candidate);
        }

        // DELETE: api/Candidates/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Candidate>> DeleteCandidate(int id)
        {
            var candidate = await _context.candidates.FindAsync(id);
            if (candidate == null)
            {
                return NotFound();
            }

            _context.candidates.Remove(candidate);
            await _context.SaveChangesAsync();

            return candidate;
        }

        private bool CandidateExists(int id)
        {
            return _context.candidates.Any(e => e.idCandidate == id);
        }
    }
}
