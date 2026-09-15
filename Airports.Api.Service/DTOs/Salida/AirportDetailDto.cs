using Airports.Api.DTOs.DTOsSalida;

namespace Airports.Api.DTOs.Salida
{
    public class AirportDetailDto
    {
        public int Id { get; set; }

        public string IataCode { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Type { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public CountryRefDto Country { get; set; } = new();

        public RegionRefDto Region { get; set; } = new();

        public bool ScheduledService { get; set; }

        public bool RunwayClosed { get; set; }

        public List<RouteRefDto> Routes { get; set; } = new();

        public List<FlightRefDto> Flights { get; set; } = new();
    }
}