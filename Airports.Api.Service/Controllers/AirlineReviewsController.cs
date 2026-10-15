using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Airports.Api.Service.Infrastructure.Data;

namespace Airports.Api.Service.Controllers
{
    [ApiController]
    [Route("api/v1/airline-reviews")]
    public class AirlineReviewsController : ControllerBase
    {
        private readonly Issco2026AirportsDbContext _context;

        public AirlineReviewsController(
            Issco2026AirportsDbContext context)
        {
            _context = context;
        }

        // GET: api/v1/airline-reviews
        [HttpGet]
        public async Task<IActionResult> GetAirlineReviews()
        {
            var reviews = await _context.AirlineReviews
                .AsNoTracking()
                .ToListAsync();

            return Ok(reviews);
        }

        // GET: api/v1/airline-reviews/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAirlineReview(int id)
        {
            var review = await _context.AirlineReviews
                .AsNoTracking()
                .FirstOrDefaultAsync(r => r.Id == id);

            if (review == null)
            {
                return NotFound();
            }

            return Ok(review);
        }
// POST: /api/v1/airline-reviews
[HttpPost]
        public IActionResult CreateAirlineReview()
        {
            return Ok();
        }

        // PUT: /api/v1/airline-reviews/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateAirlineReview(int id)
        {
            return Ok();
        }

        // DELETE: /api/v1/airline-reviews/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteAirlineReview(int id)
        {
            return Ok();
        }
    }
}