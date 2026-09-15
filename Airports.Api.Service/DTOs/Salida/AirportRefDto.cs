namespace Airports.Api.DTOs.Salida
{
    public class AirportRefDto
    {
        public int Id { get; set; }

        public string IataCode { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;
    }
}