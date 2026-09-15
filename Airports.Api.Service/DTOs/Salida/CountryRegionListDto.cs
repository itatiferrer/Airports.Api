namespace Airports.Api.DTOs.Salida
{
    public class CountryRegionListDto
    {
        public int Id { get; set; }

        public string Code { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public int AirportCount { get; set; }
    }
}