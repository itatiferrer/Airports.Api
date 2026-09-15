using Airports.Api.DTOs.DTOsSalida;

namespace Airports.Api.DTOs.Salida
{
    public class AirlineReviewListDto
    {
        public int Id { get; set; }

        public AirlineRefDto Airline { get; set; } = new();

        public int ReviewId { get; set; }

        public int OverallRating { get; set; }

        public string TypeOfTraveller { get; set; } = string.Empty;

        public string SeatType { get; set; } = string.Empty;

        public bool Recommended { get; set; }

        public decimal AverageAspectRating { get; set; }
    }
}