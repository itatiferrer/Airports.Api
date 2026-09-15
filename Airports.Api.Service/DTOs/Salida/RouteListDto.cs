using Airports.Api.DTOs.DTOsSalida;

namespace Airports.Api.DTOs.Salida
{
    public class RouteListDto
    {
        public int Id { get; set; }

        public AirlineRefDto Airline { get; set; } = new();

        public AirportRefDto OriginAirport { get; set; } = new();

        public AirportRefDto DestinationAirport { get; set; } = new();
    }
}
