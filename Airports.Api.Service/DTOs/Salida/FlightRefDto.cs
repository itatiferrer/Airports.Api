namespace Airports.Api.DTOs.Salida
{
    public class FlightRefDto
    {
        public int Id { get; set; }

        public string FlightNumber { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;
    }
}