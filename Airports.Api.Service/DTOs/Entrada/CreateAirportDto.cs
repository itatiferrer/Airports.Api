namespace Airports.Api.DTOs.Entrada
{
    public class CreateAirportDto
    {
        public string IataCode { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Type { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public int CountryId { get; set; }

        public int? RegionId { get; set; }

        public string? RegionCode { get; set; }

        public string? RegionName { get; set; }

        public bool ScheduledService { get; set; }

        public bool RunwayClosed { get; set; }
    }
}