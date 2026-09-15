using Airports.Api.DTOs.DTOsSalida;

namespace Airports.Api.DTOs.Salida
{
    public class RouteRefDto
    {
        public int Id { get; set; }

        public string OriginAirportIataCode { get; set; } = string.Empty;

        public string DestinationAirportIataCode { get; set; } = string.Empty;

        public AirlineRefDto Airline { get; set; } = new();
    }
}