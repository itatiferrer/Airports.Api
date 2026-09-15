namespace Airports.Api.DTOs.DTOsSalida
{
    public class AirlineReviewDetailDto
    {
        public int Id { get; set; }

        public AirlineRefDto Airline { get; set; } = new();

        public int ReviewId { get; set; }

        public int OverallRating { get; set; }

        public string TypeOfTraveller { get; set; } = string.Empty;

        public string SeatType { get; set; } = string.Empty;

        public bool Recommended { get; set; }

        public List<AirlineReviewAspectDto> Aspects { get; set; } = new();
    }
}