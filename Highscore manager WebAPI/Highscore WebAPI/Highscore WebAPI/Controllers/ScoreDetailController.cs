using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Highscore_WebAPI.Models;

namespace Highscore_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreDetailController : ControllerBase
    {
        private readonly ScoreDetailContext _context;

        public ScoreDetailController(ScoreDetailContext context)
        {
            _context = context;
        }

        // GET: api/ScoreDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ScoreDetail>>> GetScoreDetails()
        {
            return await _context.ScoreDetails.ToListAsync();
        }

        // GET: api/ScoreDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ScoreDetail>> GetScoreDetail(int id)
        {
            var scoreDetail = await _context.ScoreDetails.FindAsync(id);

            if (scoreDetail == null)
            {
                return NotFound();
            }

            return scoreDetail;
        }

        // PUT: api/ScoreDetail/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutScoreDetail(int id, ScoreDetail scoreDetail)
        {
            if (id != scoreDetail.ScoreDetailId)
            {
                return BadRequest();
            }

            _context.Entry(scoreDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScoreDetailExists(id))
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

        // POST: api/ScoreDetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ScoreDetail>> PostScoreDetail(ScoreDetail scoreDetail)
        {
            _context.ScoreDetails.Add(scoreDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetScoreDetail", new { id = scoreDetail.ScoreDetailId }, scoreDetail);
        }

        // DELETE: api/ScoreDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteScoreDetail(int id)
        {
            var scoreDetail = await _context.ScoreDetails.FindAsync(id);
            if (scoreDetail == null)
            {
                return NotFound();
            }

            _context.ScoreDetails.Remove(scoreDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ScoreDetailExists(int id)
        {
            return _context.ScoreDetails.Any(e => e.ScoreDetailId == id);
        }
    }
}
