using Microsoft.AspNetCore.Mvc;

namespace Airports.Api.Service.Controllers
{
    [ApiController]
    [Route("api/v1/airline-reviews")]
    public class AirlineReviewsController : ControllerBase
    {
        // GET: /api/v1/airline-reviews
        [HttpGet]
        public IActionResult GetAirlineReviews()
        {
            return Ok();
        }

        // GET: /api/v1/airline-reviews/{id}
        [HttpGet("{id}")]
        public IActionResult GetAirlineReview(int id)
        {
            return Ok();
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