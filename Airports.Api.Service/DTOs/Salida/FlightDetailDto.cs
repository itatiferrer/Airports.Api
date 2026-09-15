using Airports.Api.DTOs.DTOsSalida;

namespace Airports.Api.DTOs.Salida
{
    public class FlightDetailDto
    {
        public int Id { get; set; }

        public string FlightNumber { get; set; } = string.Empty;

        public AirlineRefDto Airline { get; set; } = new();

        public AircraftDto Aircraft { get; set; } = new();

        public RouteRefDto Route { get; set; } = new();

        public AirportRefDto OriginAirport { get; set; } = new();

        public AirportRefDto DestinationAirport { get; set; } = new();

        public DateTime ScheduledDeparture { get; set; }

        public DateTime ScheduledArrival { get; set; }

        public DateTime? ActualDeparture { get; set; }

        public DateTime? ActualArrival { get; set; }

        public string Status { get; set; } = string.Empty;

        public int? DepartureDelayMinutes { get; set; }

        public int? ArrivalDelayMinutes { get; set; }
    }
}