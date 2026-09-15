using Airports.Api.DTOs.DTOsSalida;

namespace Airports.Api.DTOs.Salida
{
    public class CountryDetailDto
    {
        public int Id { get; set; }

        public string Code { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public List<RegionRefDto> Regions { get; set; } = new();

        public int AirportCount { get; set; }

        public List<AirlineRefDto> Airlines { get; set; } = new();
    }
}