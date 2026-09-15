using Airports.Api.DTOs.DTOsSalida;

namespace Airports.Api.DTOs.Salida
{
    public class AirlineDetailDto
    {
        public int Id { get; set; }

        public string IataCode { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public CountryRefDto Country { get; set; } = new();

        public List<CountryRefDto> OperatingCountries { get; set; } = new();

        public int TotalFlights { get; set; }

        public int TotalReviews { get; set; }

        public decimal AverageRating { get; set; }
    }
}