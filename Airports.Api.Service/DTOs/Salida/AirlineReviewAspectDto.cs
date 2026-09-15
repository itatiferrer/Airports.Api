namespace Airports.Api.DTOs.DTOsSalida
{
    public class AirlineReviewAspectDto
    {
        public int ReviewAspectId { get; set; }

        public string Code { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Value { get; set; }
    }
}