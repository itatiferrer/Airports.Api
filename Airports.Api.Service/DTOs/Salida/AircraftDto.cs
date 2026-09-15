namespace Airports.Api.DTOs.DTOsSalida
{
    public class AircraftDto
    {
        public int Id { get; set; }

        public string IataCode { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;
    }
}