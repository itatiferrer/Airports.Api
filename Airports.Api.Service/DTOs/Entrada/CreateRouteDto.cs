namespace Airports.Api.DTOs.Entrada
{
    public class CreateRouteDto
    {
        public int AirlineId { get; set; }

        public int OriginAirportId { get; set; }

        public int DestinationAirportId { get; set; }
    }
}