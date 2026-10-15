
namespace Airports.Api.DTOs.DTOsEntrada
    {
        public class GetAirportsParameters
        {
            public string? Name { get; set; }

            public string? City { get; set; }

            public int? CountryId { get; set; }

            public string? IataCode { get; set; }

            public int? RegionId { get; set; }
        }
    }
