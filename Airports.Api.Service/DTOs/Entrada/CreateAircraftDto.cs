namespace Airports.Api.DTOs.DTOsEntrada
{
    public class CreateAircraftDto
    {
        public string IataCode { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;
    }
}