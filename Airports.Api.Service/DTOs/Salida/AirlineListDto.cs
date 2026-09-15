using Airports.Api.DTOs.DTOsSalida;

namespace Airports.Api.DTOs.Salida
{
    public class AirlineListDto
    {
        public int Id { get; set; }

        public string IataCode { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public CountryRefDto Country { get; set; } = new();

        public int OperatingCountriesCount { get; set; }
    }
}
