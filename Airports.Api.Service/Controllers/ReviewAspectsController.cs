using Microsoft.AspNetCore.Mvc;

namespace Airports.Api.Service.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ReviewAspectsController : ControllerBase
    {
        // GET: /api/v1/review-aspects
        [HttpGet]
        public IActionResult GetReviewAspects()
        {
            return Ok();
        }

        // POST: /api/v1/review-aspects
        [HttpPost]
        public IActionResult CreateReviewAspect()
        {
            return Ok();
        }
    }
}