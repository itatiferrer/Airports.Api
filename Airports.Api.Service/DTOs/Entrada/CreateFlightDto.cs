namespace Airports.Api.DTOs.Entrada
{
    public class CreateFlightDto
    {
        public int AirlineId { get; set; }

        public int AircraftId { get; set; }

        public int RouteId { get; set; }

        public string FlightNumber { get; set; } = string.Empty;

        public DateTime ScheduledDeparture { get; set; }

        public DateTime ScheduledArrival { get; set; }

        public DateTime? ActualDeparture { get; set; }

        public DateTime? ActualArrival { get; set; }
    }
}
