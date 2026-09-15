namespace Airports.Api.DTOs.DTOsEntrada
{
    public class CreateAirlineReviewDto
    {
        public int AirlineId { get; set; }

        public int ReviewId { get; set; }

        public int OverallRating { get; set; }

        public string ReviewTitle { get; set; } = string.Empty;

        public DateTime ReviewDate { get; set; }

        public string Review { get; set; } = string.Empty;

        public bool Verified { get; set; }

        public string Aircraft { get; set; } = string.Empty;

        public string TypeOfTraveller { get; set; } = string.Empty;

        public string SeatType { get; set; } = string.Empty;

        public string Route { get; set; } = string.Empty;

        public DateTime DateFlown { get; set; }

        public bool Recommended { get; set; }

        public List<CreateAirlineReviewAspectDto> Aspects { get; set; } = new();
    }
}